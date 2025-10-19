<?php 
session_start(); // Start the session to store success messages

require '../dbcon.php';

// Assuming you have a logged-in user with employee_id stored in session
$employee_id = $_SESSION['employee_id'];  // Set this according to your session management

// Handle image insertion
if (isset($_POST['add_image'])) {
    $title = $_POST['title'];
    $category_name = $_POST['category'];  // Get category_name from the form

    // Find category_id by fetching the category_id from Image_Categories based on category_name
    $sql_category = "SELECT category_id FROM Image_Categories WHERE category_name = '$category_name'";
    $result_category = mysqli_query($con, $sql_category);
    if ($result_category && mysqli_num_rows($result_category) > 0) {
        $category = mysqli_fetch_assoc($result_category);
        $category_id = $category['category_id'];  // Get the category_id
    } else {
        // Handle category not found issue
        echo "Category not found.";
        exit;
    }

    // Handle image upload
    $image = $_FILES['image']['name'];
    $image_temp = $_FILES['image']['tmp_name'];
    $upload_dir = '../images/'; // Place where images are stored
    $image_path = $upload_dir . basename($image);

    if (move_uploaded_file($image_temp, $image_path)) {
        $sql = "INSERT INTO Image_Gallery (title, image_url, category_id, created_by) VALUES ('$title', '$image_path', '$category_id', '$employee_id')";
        if (mysqli_query($con, $sql)) {
            $_SESSION['success_message'] = "Image added successfully!"; // Store success message
            header("Location: " . $_SERVER['PHP_SELF']);
            exit;
        } else {
            echo "Error: " . mysqli_error($con);
        }
    } else {
        echo "Image upload failed.";
    }
}

// Handle image deletion
if (isset($_GET['delete_image'])) {
    $image_id = $_GET['delete_image'];

    // Fetch the image path from the database
    $sql = "SELECT image_url FROM Image_Gallery WHERE gallery_id = $image_id";
    $result = mysqli_query($con, $sql);
    $row = mysqli_fetch_assoc($result);
    $image_path = $row['image_url'];

    // Delete the image file from the server
    if (unlink($image_path)) {
        // Delete the image record from the database
        $sql = "DELETE FROM Image_Gallery WHERE gallery_id = $image_id";
        if (mysqli_query($con, $sql)) {
            $_SESSION['success_message'] = "Image deleted successfully!"; // Store success message
            header("Location: " . $_SERVER['PHP_SELF']);
            exit;
        } else {
            echo "Error: " . mysqli_error($con);
        }
    } else {
        echo "Error deleting image file.";
    }
}

// Handle image update
if (isset($_POST['update_image'])) {
    $image_id = $_POST['image_id'];
    $title = $_POST['title'];
    $category_name = $_POST['category'];  // Get category_name from the form

    // Find category_id by getting the category_id from Image_Categories based on category_name
    $sql_category = "SELECT category_id FROM Image_Categories WHERE category_name = '$category_name'";
    $result_category = mysqli_query($con, $sql_category);
    if ($result_category && mysqli_num_rows($result_category) > 0) {
        $category = mysqli_fetch_assoc($result_category);
        $category_id = $category['category_id'];  // Get the category_id
    } else {
        // Handle category not found issue
        echo "Category not found.";
        exit;
    }

    if ($_FILES['image']['name']) {
        $image = $_FILES['image']['name'];
        $image_temp = $_FILES['image']['tmp_name'];
        $upload_dir = '../images/'; // Image directory
        $image_path = $upload_dir . basename($image);

        if (move_uploaded_file($image_temp, $image_path)) {
            $sql = "UPDATE Image_Gallery SET title='$title', image_url='$image_path', category_id='$category_id', created_by='$employee_id' WHERE gallery_id=$image_id";
            if (mysqli_query($con, $sql)) {
                $_SESSION['success_message'] = "Image updated successfully!"; // Store success message
                header("Location: " . $_SERVER['PHP_SELF']);
                exit;
            } else {
                echo "Error: " . mysqli_error($con);
            }
        } else {
            echo "Error uploading image.";
        }
    } else {
        $sql = "UPDATE Image_Gallery SET title='$title', category_id='$category_id', created_by='$employee_id' WHERE gallery_id=$image_id";
        if (mysqli_query($con, $sql)) {
            $_SESSION['success_message'] = "Image updated successfully!"; // Store success message
            header("Location: " . $_SERVER['PHP_SELF']);
            exit;
        } else {
            echo "Error: " . mysqli_error($con);
        }
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gallery</title>
    <link rel="stylesheet" href="css/GalleryPageManager.css">
</head>
<body>
<?php include('AdminNavigationBar.php'); ?>

<!-- Display Success Message -->
<?php
if (isset($_SESSION['success_message'])) {
    echo '<div class="success-message">' . $_SESSION['success_message'] . '</div>';
    unset($_SESSION['success_message']); // Clear message after displaying
}
?>

<?php
// Fetch all categories from Image_Categories table
$sql_categories = "SELECT * FROM Image_Categories";
$categories_result = mysqli_query($con, $sql_categories);

// Display the form for adding or editing images
if (isset($_GET['edit_image'])) {
    $image_id = $_GET['edit_image'];
    $sql = "SELECT * FROM Image_Gallery WHERE gallery_id = $image_id";
    $result = mysqli_query($con, $sql);
    $image = mysqli_fetch_assoc($result);
?>

<!-- Update Image Form -->
<div class="gallery-section form-container">
    <h2 class="section-title">Update Image</h2>
    <form action="" method="POST" enctype="multipart/form-data">
        <input type="hidden" name="image_id" value="<?php echo $image['gallery_id']; ?>">

        <label for="category">Category:</label>
        <select name="category" id="category">
            <?php
            while ($category = mysqli_fetch_assoc($categories_result)) {
                $selected = $category['category_name'] == $image['category_name'] ? 'selected' : '';
                echo "<option value='" . $category['category_name'] . "' $selected>" . $category['category_name'] . "</option>";
            }
            ?>
        </select><br><br>

        <label for="title">Title:</label>
        <input type="text" name="title" id="title" value="<?php echo $image['title']; ?>" required><br><br>

        <label for="image">Select Image:</label>
        <input type="file" name="image" id="image" accept="image/*"><br><br>

        <img src="<?php echo $image['image_url']; ?>" alt="Current Image" style="width: 100px; height: 100px;"><br><br>

        <button type="submit" name="update_image">Update Image</button>
    </form>
</div>

<?php
} else {
?>

<!-- Add New Image Form -->
<div class="gallery-section form-container">
    <h2 class="section-title">Add New Image</h2>
    <form action="" method="POST" enctype="multipart/form-data">
        <label for="category">Category:</label>
        <select name="category" id="category">
            <?php
            // Reset the categories result to the start for adding new image
            mysqli_data_seek($categories_result, 0);
            while ($category = mysqli_fetch_assoc($categories_result)) {
                echo "<option value='" . $category['category_name'] . "'>" . $category['category_name'] . "</option>";
            }
            ?>
        </select><br><br>

        <label for="title">Title:</label>
        <input type="text" name="title" id="title" required><br><br>

        <label for="image">Select Image:</label>
        <input type="file" name="image" id="image" accept="image/*" required><br><br>

        <button type="submit" name="add_image">Add Image</button>
    </form>
</div>

<?php
}
?>

<!-- Gallery Display -->
<div class="gallery-section">
    <h2 class="section-title">Gallery</h2>
    <div class="gallery-container">
        <?php
        // Display all images from the database
        $sql = "SELECT * FROM Image_Gallery ORDER BY created_at DESC";
        $result = mysqli_query($con, $sql);

        while ($row = mysqli_fetch_assoc($result)) {
            echo '<div class="gallery-item">';
            echo '<img src="' . $row['image_url'] . '" alt="' . $row['title'] . '">';
            echo '<div class="caption">' . $row['title'] . '</div>';
            echo '<div class="update-delete-btns">';
            echo '<a href="?delete_image=' . $row['gallery_id'] . '" style="background-color: red;" onclick="return confirmDelete();">Delete</a>';
            echo '<a href="?edit_image=' . $row['gallery_id'] . '" style="background-color: blue;">Edit</a>';
            echo '</div>';
            echo '</div>';
        }
        ?>
    </div>
</div>

<?php include('../AdminFooterBar.php'); ?>

</body>
</html>

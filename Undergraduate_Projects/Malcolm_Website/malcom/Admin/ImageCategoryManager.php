<?php
session_start(); // Start the session for message storage

require '../dbcon.php';

// Ensure that the employee's ID is available (from the session)
$employee_id = $_SESSION['employee_id'];  // Make sure this session variable is set correctly after login

// Success message variable
$success_message = '';

// Handle Category Add
if (isset($_POST['add_category'])) {
    $category_name = $_POST['category_name'];
    
    // Insert category with the created_by field
    $sql = "INSERT INTO Image_Categories (category_name, created_by) VALUES ('$category_name', '$employee_id')";
    if (mysqli_query($con, $sql)) {
        $_SESSION['success_message'] = "Category added successfully!";
        // Redirect after successful insert to avoid form resubmission
        header("Location: " . $_SERVER['PHP_SELF']);
        exit;
    } else {
        echo "Error: " . mysqli_error($con);
    }
}

// Handle Category Update
if (isset($_POST['update_category'])) {
    $category_id = $_POST['category_id'];
    $category_name = $_POST['category_name'];
    
    // Update category with the created_by field
    $sql = "UPDATE Image_Categories SET category_name = '$category_name', created_by = '$employee_id' WHERE category_id = $category_id";
    if (mysqli_query($con, $sql)) {
        $_SESSION['success_message'] = "Category updated successfully!";
        // Redirect back to the category management page after update
        header("Location: ImageCategoryManager.php");
        exit;
    } else {
        echo "Error: " . mysqli_error($con);
    }
}

// Handle Category Delete
if (isset($_GET['delete_category'])) {
    $category_id = $_GET['delete_category'];
    $sql = "DELETE FROM Image_Categories WHERE category_id = $category_id";
    if (mysqli_query($con, $sql)) {
        $_SESSION['success_message'] = "Category deleted successfully!";
        // Redirect to avoid resubmission on refresh
        header("Location: " . $_SERVER['PHP_SELF']);
        exit;
    } else {
        echo "Error: " . mysqli_error($con);
    }
}

// Fetch Categories
$sql_categories = "SELECT * FROM Image_Categories";
$categories_result = mysqli_query($con, $sql_categories);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Manage Categories</title>
    <link rel="stylesheet" href="css/ImageCategoryManager.css">
</head>
<body>
<?php include('AdminNavigationBar.php'); ?>
<div class="container">
    <h1>Manage Categories</h1>

    <!-- Success Message -->
    <?php
    if (isset($_SESSION['success_message'])) {
        echo '<div class="success-message">' . $_SESSION['success_message'] . '</div>';
        unset($_SESSION['success_message']); // Clear the success message after displaying it
    }
    ?>

    <!-- Category Management -->
    <div class="form-container">
        <h2><?php echo isset($_GET['edit_category']) ? 'Update Category' : 'Add New Category'; ?></h2>
        <form action="" method="POST">
            <?php if (isset($_GET['edit_category'])): 
                $category_id = $_GET['edit_category'];
                $sql = "SELECT * FROM Image_Categories WHERE category_id = $category_id";
                $result = mysqli_query($con, $sql);
                $category = mysqli_fetch_assoc($result);
            ?>
                <input type="hidden" name="category_id" value="<?php echo $category['category_id']; ?>">
            <?php endif; ?>
            <input type="text" name="category_name" value="<?php echo isset($category) ? $category['category_name'] : ''; ?>" placeholder="Category Name" required>
            <button type="submit" name="<?php echo isset($category) ? 'update_category' : 'add_category'; ?>">
                <?php echo isset($category) ? 'Update Category' : 'Add Category'; ?>
            </button>
        </form>
    </div>

    <!-- Category List -->
    <div class="category-list">
        <?php while ($category = mysqli_fetch_assoc($categories_result)) { ?>
            <div class="category-card">
                <h3><?php echo $category['category_name']; ?></h3>
                <div class="btn-actions">
                    <a href="?edit_category=<?php echo $category['category_id']; ?>">Edit</a>
                    <a href="?delete_category=<?php echo $category['category_id']; ?>" onclick="return confirm('Are you sure you want to delete this category?');" class="delete">Delete</a>
                </div>
            </div>
        <?php } ?>
    </div>

</div>
<?php include('../AdminFooterBar.php'); ?>
</body>
</html>



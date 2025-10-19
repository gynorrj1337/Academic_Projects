<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Malcolm Lismore - Gallery</title>
    <link rel="stylesheet" href="css/GalleryPage.css">
</head>
<body>
    <?php include('NavigationBar.php'); ?>
    <div class="gallery-section">
        <?php
            require '../dbcon.php';
            // Fetch all image categories
            $category_sql = "SELECT * FROM Image_Categories ORDER BY category_name ASC";
            $category_result = mysqli_query($con, $category_sql);

            // Loop through categories
            while ($category = mysqli_fetch_assoc($category_result)) {
                $category_id = $category['category_id'];  // Updated column name
                $category_name = $category['category_name'];
                
                // Fetch images for the current category
                $image_sql = "SELECT * FROM Image_Gallery WHERE category_id = $category_id ORDER BY created_at DESC";
                $image_result = mysqli_query($con, $image_sql);
        ?>
        <h2 class="section-title"><?php echo $category_name . ' Photography'; ?></h2>
        <div class="gallery-container">
            <?php
                // Check if images exist for the current category
                if ($image_result && mysqli_num_rows($image_result) > 0) {
                    // Loop through images for the current category
                    while ($image = mysqli_fetch_assoc($image_result)) {
                        echo '<div class="gallery-item">';
                        echo '<img src="' . $image['image_url'] . '" alt="' . $image['title'] . '">';  // Using updated column name
                        echo '<div class="caption">' . $image['title'] . '</div>';
                        echo '</div>';
                    }
                } else {
                    echo '<p>No images available in this category.</p>';
                }
            ?>
        </div>
        <?php } // End of category loop ?>
    </div>
    <?php include('../FooterBar.php'); ?>
</body>
</html>


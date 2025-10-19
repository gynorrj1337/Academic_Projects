<?php
// Include the database connection
require 'dbcon.php';
// Setting variables for success/error messages
$success_message = '';
$error_message = '';
// Fetch all pricing details from the Pricing table
$sql_pricing = "SELECT * FROM Pricing";
$res_pricing = mysqli_query($con, $sql_pricing);
// Fetching pricing data as an associative array
$pricing_data = mysqli_fetch_all($res_pricing, MYSQLI_ASSOC);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Malcolm Lismore - Pricing Plans</title>
    <link rel="stylesheet" href="css/PricePage.css">
</head>
<body>
    <?php include('NavigationBar.php'); ?>
    <div class="container">
        <h1 class="pricing-header">Our Pricing Plans</h1>
        <!-- Pricing Cards Section -->
        <div class="pricing-cards">
            <?php foreach ($pricing_data as $package): ?>
                <div class="pricing-card">
                    <h3><?php echo $package['Pack_name']; ?></h3>
                    <p>Package Duration: <?php echo $package['Pack_hours']; ?> Hours</p>
                    <p>Package Photos: <?php echo $package['Pack_pics']; ?> Photos</p>
                    <div class="price">$<?php echo number_format($package['Pack_price'], 2); ?></div>
                    <ul class="features">
                        <li>Duration: <?php echo $package['Pack_hours']; ?> Hours</li>
                        <li>Photos: <?php echo $package['Pack_pics']; ?> Photos</li>
                        <li>Price: $<?php echo number_format($package['Pack_price'], 2); ?></li>
                    </ul>
                    <a href="InquiryPage.php" class="btn">Book Now</a>
                </div>
            <?php endforeach; ?>
        </div>
    </div>
    <br>
    <?php include('../FooterBar.php'); ?>
</body>
</html>


<?php
// Include the database connection
require '../dbcon.php';

// Setting variables for success/error messages
$success_message = '';
$error_message = '';

// Start session for message handling
session_start();

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = $_POST['name'];
    $email = $_POST['email'];
    $message = $_POST['message'];
    $location = isset($_POST['location']) ? $_POST['location'] : NULL;
    $event_date = isset($_POST['event_date']) ? $_POST['event_date'] : NULL;
    $package_name = $_POST['package_name'];
    
    // Get today's date for comparison
    $today = date('Y-m-d');
    
    // Check if the event date is in the future
    if ($event_date && $event_date <= $today) {
        $_SESSION['error_message'] = "Event date must be greater than today's date.";
    } else {
        // Get the package_id from the Pricing table based on the selected package name
        $sql_package = "SELECT pricing_id FROM Pricing WHERE Pack_name = '$package_name' LIMIT 1";
        $result = mysqli_query($con, $sql_package);
        $package_id = null;

        if (mysqli_num_rows($result) > 0) {
            $row = mysqli_fetch_assoc($result);
            $package_id = $row['pricing_id'];
        }

        if ($package_id) {
            // Insert data into Inquires table
            $sql = "INSERT INTO Inquires (customer_name, email, message, location, event_date, package_id) 
                    VALUES ('$name', '$email', '$message', '$location', '$event_date', '$package_id')";

            if (mysqli_query($con, $sql)) {
                $_SESSION['success_message'] = "Your message has been sent successfully!";
                // Redirect after successful form submission to avoid resubmission on refresh
                header("Location: " . $_SERVER['PHP_SELF']);
                exit;
            } else {
                $_SESSION['error_message'] = "There was an error sending your message. Please try again later.";
            }
        } else {
            $_SESSION['error_message'] = "Invalid package selected.";
        }
    }
}

// Fetch available package names for the dropdown
// Updated column name: Pack_name
$sql_packages = "SELECT Pack_name FROM Pricing";
$res_packages = mysqli_query($con, $sql_packages);
$packages = mysqli_fetch_all($res_packages, MYSQLI_ASSOC);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Malcolm Lismore - Contact Us</title>
    <link rel="stylesheet" href="css/InquiryPage.css">
</head>
<body>

    <?php include('NavigationBar.php'); ?>

    <div class="container">
        <h1 class="contact-header">Contact Us</h1>

        <!-- Contact Details Section -->
        <div class="contact-details">
            <div>
                <h3>Email Us</h3>
                <p>contact.malcom@gmail.com</p>
            </div>
            <div>
                <h3>Call Us</h3>
                <p>+94 117 572 572</p>
            </div>
            <div>
                <h3>Visit Us</h3>
                <p>No. 08, Church Road,<br> Wattala 11300</p>
            </div>
        </div>

        <!-- Success/Error Messages -->
        <?php if (isset($_SESSION['success_message'])): ?>
            <div class="message success show"><?php echo $_SESSION['success_message']; ?></div>
            <?php unset($_SESSION['success_message']); ?>
        <?php elseif (isset($_SESSION['error_message'])): ?>
            <div class="message error show"><?php echo $_SESSION['error_message']; ?></div>
            <?php unset($_SESSION['error_message']); ?>
        <?php endif; ?>

        <!-- Contact Form Section -->
        <div class="contact-form">
            <h3>Send Us a Message</h3>
            <form action="" method="POST">
                <input type="text" name="name" placeholder="Your Name" required>
                <input type="email" name="email" placeholder="Your Email" required>
                <textarea name="message" rows="6" placeholder="Your Message" required></textarea>
                <input type="text" name="location" placeholder="Your Location (optional)">
                <input type="date" name="event_date" placeholder="Event Date (optional)">
                
                <!-- Package Dropdown -->
                <select name="package_name" required>
                    <option value="" disabled selected>Select a Package</option>
                    <?php foreach ($packages as $package): ?>
                        <option value="<?php echo $package['Pack_name']; ?>"><?php echo $package['Pack_name']; ?></option>
                    <?php endforeach; ?>
                </select>

                <input type="submit" value="Send Message">
            </form>
        </div>
    </div>

    <br>
    <?php include('../FooterBar.php'); ?>

    <script>
    // JavaScript Validation for Event Date (before form submission)
    document.querySelector("form").addEventListener("submit", function(event) {
        const eventDate = document.querySelector("input[name='event_date']").value;
        const today = new Date().toISOString().split('T')[0]; // Current date in YYYY-MM-DD format

        if (eventDate && eventDate <= today) {
            alert("Event date must be greater than today's date.");
            event.preventDefault(); // Prevent form submission
        }
    });
    </script>

</body>
</html>


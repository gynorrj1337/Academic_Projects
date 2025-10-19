<?php
// Start the session to use session variables
session_start();

// Initialize error messages and form data
$error_message = '';
$success_message = '';
$admin_id = ''; // Renamed to match 'employee_id'
$password = '';

// Database connection
$servername = "localhost"; // server name (e.g., localhost)
$username = "root"; // database username
$db_password = ""; // database password
$dbname = "malcolm"; // Database name

// Create connection
$conn = new mysqli($servername, $username, $db_password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Check if form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Collect data from the form
    $admin_id = $_POST['admin-id']; // 'admin-id' should still be used for form field
    $password = $_POST['password'];

    // Simple validation
    if (empty($admin_id) || empty($password)) {
        $error_message = "Both Admin ID and Password are required!";
    } else {
        // Query to check if the employee exists in the Employee table using employee_id
        $sql = "SELECT * FROM Employee WHERE employee_id = ?"; // Using employee_id from Employee table
        $stmt = $conn->prepare($sql);
        $stmt->bind_param("i", $admin_id); // Binding as integer (employee_id is INT)
        $stmt->execute();
        $result = $stmt->get_result();

        // If the employee is found
        if ($result->num_rows > 0) {
            $employee = $result->fetch_assoc();

            // Directly compare the passwords (Note: passwords should be hashed in real-world applications)
            if ($password == $employee['password']) { // Check password against the stored value
                // Successful login, store employee_id in session and redirect to another page
                $_SESSION['employee_id'] = $employee['employee_id']; // Store employee_id in session
                header("Location: ../Admin/AdminHomePage.php"); // Redirect to dashboard.php or any other page
                exit(); // Stop further script execution after the redirect
            } else {
                $error_message = "Incorrect password!";
            }
        } else {
            $error_message = "Employee not found!";
        }

        // Close the statement
        $stmt->close();
    }
}

// Close the database connection
$conn->close();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Malcolm Lismore - Contact Us</title>
    <link rel="stylesheet" href="css/SignInPage.css">
</head>
<body>
    <?php include('NavigationBar.php'); ?>

    <div class="container">
        <div class="left">
            <img src="../images/assets/Login.png" alt="Login Image" style="max-width: 100%; height: auto;">
        </div>
        <div class="right">
            <h2>Sign In</h2>
            
            <?php if ($success_message): ?>
                <div class="success"><?php echo $success_message; ?></div>
            <?php elseif ($error_message): ?>
                <div class="error"><?php echo $error_message; ?></div>
            <?php endif; ?>
            
            <form id="loginForm" method="POST" action="">
                <div>
                    <label for="admin-id">Admin ID</label>
                    <input type="text" id="admin-id" name="admin-id" value="<?php echo htmlspecialchars($admin_id); ?>">
                    <div id="admin-id-error" class="error"></div>
                </div>
                <div>
                    <label for="password">Password</label>
                    <input type="password" id="password" name="password" value="<?php echo htmlspecialchars($password); ?>">
                    <div id="password-error" class="error"></div>
                </div>
                <div class="buttons">
                    <input type="button" value="Clear" onclick="clearFields()">
                    <input type="submit" value="Sign In">
                </div>
            </form>
        </div>
    </div>

    <script>
        // Function to clear the input fields
        function clearFields() {
            document.getElementById('admin-id').value = '';
            document.getElementById('password').value = '';
            document.getElementById('admin-id-error').innerText = '';
            document.getElementById('password-error').innerText = '';
        }
    </script>

    <?php include('../FooterBar.php'); ?>
</body>
</html>

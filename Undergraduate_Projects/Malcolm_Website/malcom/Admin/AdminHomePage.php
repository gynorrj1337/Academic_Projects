<?php
// Start the session to store success message
session_start();

// Database connection
$servername = "localhost"; 
$username = "root"; 
$db_password = ""; 
$dbname = "malcolm"; 

// Create connection
$conn = new mysqli($servername, $username, $db_password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$error_message = '';
$start_date = '';
$end_date = '';

// Handle Category Delete
if (isset($_GET['delete_id'])) {
    $delete_id = $_GET['delete_id'];
    $sql = "DELETE FROM Inquires WHERE inquires_id = $delete_id";
    if ($conn->query($sql) === TRUE) {
        $_SESSION['success_message'] = "Message deleted successfully!";
        // Redirect to avoid resubmission on refresh
        header("Location: " . $_SERVER['PHP_SELF']);
        exit;
    } else {
        echo "Error: " . $conn->error;
    }
}

// Check if form is submitted for date filtering
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $start_date = $_POST['start_date'];
    $end_date = $_POST['end_date'];

    if (empty($start_date) || empty($end_date)) {
        $error_message = "Both start date and end date are required!";
    }
}

// Query to fetch inquiries
$sql = "
    SELECT i.*, p.Pack_name AS category_name, p.Pack_price AS price
    FROM Inquires i
    JOIN Pricing p ON i.package_id = p.pricing_id  -- Adjusted column names (pricing_id)
";
$where_clause = "";

if (!empty($start_date) && !empty($end_date)) {
    $where_clause = " WHERE i.event_date BETWEEN '$start_date' AND '$end_date'";
}

$sql .= $where_clause;

$result = $conn->query($sql);

// Close the connection
$conn->close();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Messages - Malcolm Lismore</title>
    <link rel="stylesheet" href="css/AdminHomePage.css">
    <script>
        function confirmDelete(event) {
            var result = confirm("Are you sure you want to delete this message?");
            if (!result) {
                event.preventDefault();  // Prevents the deletion if the user cancels
            }
        }
    </script>
</head>
<body>
<?php include('AdminNavigationBar.php'); ?>
<div class="container">
    <div class="inbox">
        <h2>Inbox - Messages</h2>

        <!-- Date filter form -->
        <div class="filter-container">
            <form method="POST" action="">
                <div>
                    <input type="date" name="start_date" value="<?php echo $start_date; ?>" required>
                    <input type="date" name="end_date" value="<?php echo $end_date; ?>" required>
                </div>
                <button type="submit">Filter by Date</button>
            </form>
        </div>

        <!-- Display Success Message -->
        <?php if (isset($_SESSION['success_message'])): ?>
            <div class="success-message"><?php echo $_SESSION['success_message']; unset($_SESSION['success_message']); ?></div>
        <?php endif; ?>

        <!-- Error message for validation -->
        <?php if ($error_message): ?>
            <div class="error"><?php echo $error_message; ?></div>
        <?php endif; ?>

        <!-- Inquiries table -->
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Message</th>
                    <th>Location</th>
                    <th>Event Date</th>
                    <th>Category Name</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <?php
                if ($result->num_rows > 0) {
                    // Display inquiries data in table rows
                    while ($row = $result->fetch_assoc()) {
                        echo "<tr>";
                        echo "<td>" . $row['customer_name'] . "</td>";  // Adjusted column name (customer_name)
                        echo "<td><a href='mailto:" . $row['email'] . "' class='email-link'>" . $row['email'] . "</a></td>";
                        echo "<td>" . $row['message'] . "</td>";
                        echo "<td>" . $row['location'] . "</td>";
                        echo "<td>" . $row['event_date'] . "</td>";
                        echo "<td>" . $row['category_name'] . "</td>";
                        echo "<td><a href='?delete_id=" . $row['inquires_id'] . "' class='delete-btn' onclick='confirmDelete(event)'>Delete</a></td>"; // Adjusted to the correct column (inquires_id)
                        echo "</tr>";
                    }
                } else {
                    echo "<tr><td colspan='7'>No inquiries found for the selected date range.</td></tr>";
                }
                ?>
            </tbody>
        </table>
    </div>
</div>

<?php include('../AdminFooterBar.php'); ?>
</body>
</html>



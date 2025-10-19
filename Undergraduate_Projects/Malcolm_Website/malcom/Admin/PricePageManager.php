<?php
// Include the database connection
require '../dbcon.php';

// Start the session to use session variables
session_start();

// Ensure that the employee's ID is available (from the session)
$employee_id = $_SESSION['employee_id'];  // Make sure this session variable is set correctly after login

// Handle Insert, Update, and Delete actions
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Insert new pricing package
    if (isset($_POST['insert'])) {
        $pack_name = $_POST['pack_name'];
        $pack_hours = $_POST['pack_hours'];
        $pack_pics = $_POST['pack_pics'];
        $pack_price = $_POST['pack_price'];

        // Insert the new pricing package with the created_by field
        $sql_insert = "INSERT INTO Pricing (Pack_name, Pack_hours, Pack_pics, Pack_price, created_by) 
                       VALUES ('$pack_name', '$pack_hours', '$pack_pics', '$pack_price', '$employee_id')";
        
        if (mysqli_query($con, $sql_insert)) {
            $_SESSION['success_message'] = "Package inserted successfully!";
            // Redirect to avoid form resubmission on page refresh
            header("Location: PricePageManager.php");
            exit();
        } else {
            $_SESSION['error_message'] = "Error inserting package: " . mysqli_error($con);
        }
    }

    // Update existing pricing package
    if (isset($_POST['update'])) {
        $pricing_id = $_POST['pricing_id'];
        $pack_name = $_POST['pack_name'];
        $pack_hours = $_POST['pack_hours'];
        $pack_pics = $_POST['pack_pics'];
        $pack_price = $_POST['pack_price'];

        // Update the pricing package with the created_by field
        $sql_update = "UPDATE Pricing SET Pack_name = '$pack_name', Pack_hours = '$pack_hours', 
                       Pack_pics = '$pack_pics', Pack_price = '$pack_price', created_by = '$employee_id' 
                       WHERE pricing_id = '$pricing_id'";
        
        if (mysqli_query($con, $sql_update)) {
            $_SESSION['success_message'] = "Package updated successfully!";
            // Redirect to avoid form resubmission on page refresh
            header("Location: PricePageManager.php");
            exit();
        } else {
            $_SESSION['error_message'] = "Error updating package: " . mysqli_error($con);
        }
    }
}

// Handle delete action
if (isset($_GET['delete'])) {
    $pricing_id = $_GET['delete'];
    $sql_delete = "DELETE FROM Pricing WHERE pricing_id = '$pricing_id'";

    try {
        if (mysqli_query($con, $sql_delete)) {
            $_SESSION['success_message'] = "Package deleted successfully!";
            // Redirect after deletion to avoid resubmission
            header("Location: PricePageManager.php");
            exit();
        } else {
            // Check for foreign key violation error (error code 1451)
            if (mysqli_errno($con) == 1451) {
                $_SESSION['error_message'] = "Cannot delete this package because it is referenced by other records.";
            } else {
                $_SESSION['error_message'] = "Error deleting package: " . mysqli_error($con);
            }
        }
    } catch (mysqli_sql_exception $e) {
        $_SESSION['error_message'] = "Error: " . $e->getMessage();
    }
}

// Fetch all pricing details from the Pricing table
$sql_pricing = "SELECT * FROM Pricing";
$res_pricing = mysqli_query($con, $sql_pricing);
$pricing_data = mysqli_fetch_all($res_pricing, MYSQLI_ASSOC);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pricing Management</title>
    <link rel="stylesheet" href="css/PricePageManager.css">
</head>
<body>

    <?php include('AdminNavigationBar.php'); ?>

    <div class="container">
        <div class="header">
            <h1>Package Price Management</h1>
        </div>

        <div class="left-section">
            <!-- Success/Error Messages -->
            <?php if (isset($_SESSION['success_message'])): ?>
                <div class="message success"><?php echo $_SESSION['success_message']; unset($_SESSION['success_message']); ?></div>
            <?php elseif (isset($_SESSION['error_message'])): ?>
                <div class="message error"><?php echo $_SESSION['error_message']; unset($_SESSION['error_message']); ?></div>
            <?php endif; ?>

            <!-- Add/Edit Pricing Form -->
            <div class="form-container">
                <h3><?php echo isset($_GET['edit']) ? 'Update Package' : 'Add New Package'; ?></h3>
                <form action="PricePageManager.php" method="POST">
                    <?php
                        if (isset($_GET['edit'])) {
                            $pricing_id = $_GET['edit'];
                            $sql_edit = "SELECT * FROM Pricing WHERE pricing_id = '$pricing_id'";
                            $result_edit = mysqli_query($con, $sql_edit);
                            $package = mysqli_fetch_assoc($result_edit);
                        }
                    ?>
                    <input type="hidden" name="pricing_id" value="<?php echo $package['pricing_id'] ?? ''; ?>">
                    <input type="text" name="pack_name" placeholder="Package Name" value="<?php echo $package['Pack_name'] ?? ''; ?>" required>
                    <input type="number" name="pack_hours" placeholder="Package Hours" value="<?php echo $package['Pack_hours'] ?? ''; ?>" required>
                    <input type="number" name="pack_pics" placeholder="Number of Photos" value="<?php echo $package['Pack_pics'] ?? ''; ?>" required>
                    <input type="number" name="pack_price" placeholder="Package Price" value="<?php echo $package['Pack_price'] ?? ''; ?>" required>
                    
                    <input type="submit" name="<?php echo isset($_GET['edit']) ? 'update' : 'insert'; ?>" value="<?php echo isset($_GET['edit']) ? 'Update Package' : 'Add Package'; ?>">
                </form>
            </div>
        </div>

        <div class="right-section">
            <!-- Pricing Table -->
            <div class="pricing-table">
                <table>
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Package Name</th>
                            <th>Hours</th>
                            <th>Photos</th>
                            <th>Price</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <?php foreach ($pricing_data as $package): ?>
                            <tr>
                                <td><?php echo $package['pricing_id']; ?></td>
                                <td><?php echo $package['Pack_name']; ?></td>
                                <td><?php echo $package['Pack_hours']; ?></td>
                                <td><?php echo $package['Pack_pics']; ?></td>
                                <td>$<?php echo number_format($package['Pack_price'], 2); ?></td>
                                <td>
                                    <a href="PricePageManager.php?edit=<?php echo $package['pricing_id']; ?>">Edit</a> | 
                                    <a href="PricePageManager.php?delete=<?php echo $package['pricing_id']; ?>" onclick="return confirm('Are you sure you want to delete this package?');">Delete</a>
                                </td>
                            </tr>
                        <?php endforeach; ?>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

    <?php include('../AdminFooterBar.php'); ?>

</body>
</html>

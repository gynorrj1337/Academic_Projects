<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Under Construction</title>
    <style>* {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
    }

    body {
        font-family: 'Product Sans', 'Arial', sans-serif;
        background-color: #f5f5f5; 
        color: #333;
        margin: 0;
    }

    h1 {
        font-size: 48px;
        color: #ff6f61;
    }

    p {
        font-size: 18px;
        margin: 20px 0;
        color: #555; /* Light gray color for paragraph text */
    }

    nav {
        display: flex;
        align-items: center;
        background-color: #ffffff;
        padding: 10px 0;
        box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
    }

    nav .logo {
        margin-left: 20px;
    }

    nav a {
        color: #4285F4;
        text-decoration: none;
        font-family: 'Product Sans', 'Arial', sans-serif;
        font-size: 18px;
        font-weight: bold;
        padding: 12px 20px;
        margin: 0 15px;
        border-radius: 30px;
        transition: all 0.3s ease;
    }

    nav a.active {
        background-color: #4285F4;
        color: white;
        box-shadow: 0 2px 10px rgba(66, 133, 244, 0.3);
    }

    nav a:hover {
        background-color: #d9e4fe;
        color: #4285F4;
        transform: translateY(-2px);
    }

    nav a + a {
        margin-left: 20px;
    }

    nav .nav-links {
        margin-left: auto;
        display: flex;
        align-items: center;
    }

    /* Specific style for the Sign In button to be blue by default */
    nav a.sign-in {
        background-color: #4285F4;
        color: white;
    }

    nav a.sign-in:hover {
        background-color: #d9e4fe;
        color: #4285F4;
    }

    .container {
        text-align: center;
        background-color: #fff;
        padding: 40px;
        border-radius: 10px;
        box-shadow: 0 10px 15px rgba(0, 0, 0, 0.1);
        max-width: 700px;
        width: 80%;
        margin: 50px auto; /* Center the container */
    }

    .construction-icon {
        font-size: 120px;
        color: #ff6f61;
    }

    .email-link {
        color: #4285F4;
        text-decoration: none;
    }

    .email-link:hover {
        text-decoration: underline;
    }

    .button {
        margin-top: 30px;
        padding: 12px 25px;
        font-size: 18px;
        background-color: #4285F4; /* Blue color button to match the theme */
        color: white;
        border: none;
        border-radius: 5px;
        cursor: pointer;
        text-decoration: none;
    }

    .button:hover {
        background-color: #357ae8; /* Darker blue for hover */
    }

    @media (max-width: 768px) {
        h1 {
            font-size: 36px;
        }

        .container {
            width: 90%;
            padding: 20px;
        }
    }

    </style>
</head>
<body>
<nav>
        <img src="images/Assets/logoNav.jpg" alt="Malcolm Lismore Logo" class="logo">
        <div class="nav-links">
            <a href="Client/HomePage.php">Home</a> |
            <a href="Client/GalleryPage.php">Gallery</a> |
            <a href="Client/PricePage.php">Pricing</a> |
            <a href="Client/InquiryPage.php">Contact Us</a> |
            <a href="Client/AboutPage.php">About Us</a> |
            <a href="Client/SignInPage.php" class="sign-in">Sign In</a>
        </div>
    </nav>
    
    <div class="container">
        <div class="construction-icon">
            🚧
        </div>
        <h1>Under Construction</h1>
        <p>We are currently working on something amazing! This page will be available soon. Thank you for your patience.</p>
        <p>If you have any questions or inquiries, feel free to <a href="mailto:support@example.com" class="email-link">contact us</a>.</p>
        <a href="Client/HomePage.php" class="button">Go Back to Homepage</a>
    </div>
    
    <?php include('FooterBar.php'); ?>
</body>
</html>

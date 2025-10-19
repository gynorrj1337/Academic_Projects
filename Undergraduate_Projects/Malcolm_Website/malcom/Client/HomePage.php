<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Malcolm Lismore - Home</title>
    <link rel="stylesheet" href="css/HomePage.css">
    
</head>
<body>
<?php include('NavigationBar.php'); ?>
    <section class="hero">
        <div class="hero-images">
            <img src="../images/assets/hero1.jpg" alt="Image 1">
            <img src="../images/assets/hero2.jpg" alt="Image 2">
            <img src="../images/assets/hero3.jpg" alt="Image 3">
            <img src="../images/assets/hero4.jpg" alt="Image 4">
            <img src="../images/assets/hero5.jpg" alt="Image 5">
        </div>
        <div class="hero-text">
            <h1>Welcome to Malcolm Lismore</h1>
            <p>Discover the best of art and design</p>
            <a href="GalleryPage.php" class="btn">Explore Our Gallery</a>
        </div>

    </section>

    <section class="features">
        <h2>Our Services</h2>
        <div class="feature-item">
            <img src="../images/landscape/landscape1.jpg" alt="Landscape Photography">
            <h3>Landscape Photography</h3>
            <p>Capture the rugged and breathtaking landscapes of the North West coast of Scotland, showcasing the unique beauty of the wilderness.</p>
        </div>
        <div class="feature-item">
            <img src="../images/wildlife/wildlife1.jpg" alt="Wildlife Photography">
            <h3>Wildlife Photography</h3>
            <p>Specializing in coastal birds and other wildlife, we capture animals in their natural habitats with incredible detail and precision.</p>
        </div>
        <div class="feature-item">
            <img src="../images/wedding/wedding1.jpg" alt="Wedding Photography">
            <h3>Wedding Photography</h3>
            <p>We provide beautiful wedding photography, capturing the special moments from your ceremony to candid moments during your big day.</p>
        </div>
        <div class="feature-item">
            <img src="../images/portrait/portrait1.jpg" alt="Portrait Photography">
            <h3>Portrait Photography</h3>
            <p>Whether in natural settings or a studio, we create stunning portraits of individuals, couples, and families to cherish forever.</p>
        </div>
        <div class="feature-item">
            <img src="../images/event/event1.jpg" alt="Special Event Photography">
            <h3>Special Event Photography</h3>
            <p>Capture memorable moments at your special events, including anniversaries, birthdays, and corporate gatherings.</p>
        </div>
    </section>

    <section class="testimonials">
        <h2>What Our Clients Say</h2>
        <div class="testimonial" id="testimonial-1">
            <p>"Malcolm Lismore created a truly unique piece of art for our office. It’s a conversation starter, and we couldn't be happier!"</p>
            <h4>- Sarah Johnson, CEO</h4>
        </div>
        <div class="testimonial" id="testimonial-2">
            <p>"The art exhibitions curated by Malcolm Lismore are always exceptional. We enjoy every visit!"</p>
            <h4>- David Lee, Art Enthusiast</h4>
        </div>
        <div class="testimonial" id="testimonial-3">
            <p>"Malcolm's portrait photography services were exactly what we needed for our family pictures. The results were stunning!"</p>
            <h4>- Emily Carter, Customer</h4>
        </div>
        <div class="testimonial" id="testimonial-4">
            <p>"The wedding photos we received from Malcolm were incredible. He captured every moment beautifully!"</p>
            <h4>- Mark & Lily Grant, Newlyweds</h4>
        </div>
        <div class="testimonial" id="testimonial-5">
            <p>"We hired Malcolm for our corporate event, and he delivered fantastic photos. Highly recommended!"</p>
            <h4>- James Taylor, Event Coordinator</h4>
        </div>

    </section>

    <?php include('../FooterBar.php'); ?>

    <script>
        document.addEventListener("DOMContentLoaded", () => {
    // Image Slider Logic
    const images = document.querySelector('.hero-images');
    let currentImage = 0;
    const totalImages = images.children.length;

    // Function to show the image based on the index
    function showImage(index) {
        images.style.transform = `translateX(-${index * 100 / totalImages}%)`;
    }

    // Automatically change image every 3 seconds
    setInterval(() => {
        currentImage = (currentImage + 1) % totalImages;  // Loop through images
        showImage(currentImage);
    }, 3000); // Change image every 3 seconds

    // Testimonial Slider Logic
    const testimonials = document.querySelectorAll('.testimonial');
    let currentTestimonial = 0;
    const totalTestimonials = testimonials.length;

    // Function to show the testimonial based on the index
    function showTestimonial(index) {
        testimonials.forEach((testimonial, i) => {
            testimonial.style.display = (i === index) ? 'block' : 'none'; // Show the active testimonial
        });
    }

    // Automatically change testimonial every 5 seconds
    setInterval(() => {
        currentTestimonial = (currentTestimonial + 1) % totalTestimonials;  // Loop through testimonials
        showTestimonial(currentTestimonial);
    }, 5000); // Change testimonial every 5 seconds

    // Initialize first image and testimonial
    showImage(currentImage);
    showTestimonial(currentTestimonial);
});

    </script>
</body>
</html>

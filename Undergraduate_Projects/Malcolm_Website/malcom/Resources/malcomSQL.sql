CREATE DATABASE malcolm;
USE malcolm;

-- Create Employee table first, since other tables depend on it
CREATE TABLE Employee (
    employee_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Create Pricing table
CREATE TABLE Pricing (
    pricing_id INT AUTO_INCREMENT PRIMARY KEY,
    Pack_name VARCHAR(255) NOT NULL,
    Pack_hours INT NOT NULL,
    Pack_pics INT NOT NULL,
    Pack_price DECIMAL(10, 2) NOT NULL,
    created_by INT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (created_by) REFERENCES Employee(employee_id) ON DELETE SET NULL
);

-- Create Inquires table (dependent on Pricing)
CREATE TABLE Inquires (
    inquires_id INT AUTO_INCREMENT PRIMARY KEY,
    customer_name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    message TEXT NOT NULL,
    location VARCHAR(255),
    event_date DATE,
    package_id INT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (package_id) REFERENCES Pricing(pricing_id) ON DELETE CASCADE
);

-- Create Image_Categories table (dependent on Employee)
CREATE TABLE Image_Categories (
    category_id INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL,
    created_by INT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (created_by) REFERENCES Employee(employee_id) ON DELETE SET NULL
);

-- Create Image_Gallery table (dependent on Image_Categories and Employee)
CREATE TABLE Image_Gallery (
    gallery_id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    description TEXT,
    image_url VARCHAR(255) NOT NULL,
    category_id INT,
    created_by INT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (category_id) REFERENCES Image_Categories(category_id) ON DELETE CASCADE,
    FOREIGN KEY (created_by) REFERENCES Employee(employee_id) ON DELETE SET NULL
);

-- Insert employees
INSERT INTO Employee (name, email, password)
VALUES 
    ('Malcolm Lismore', 'malcolm@example.com', 'malcom');

-- Insert image categories with created_by
INSERT INTO Image_Categories (category_name, created_by)
VALUES 
    ('Landscape', 1),
    ('Wildlife', 1),
    ('Wedding', 1),
    ('Portraits', 1);

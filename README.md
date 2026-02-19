# Ecommerce
🛒 E-Commerce Web Application (.NET Core + Azure)

I developed a full-stack E-Commerce web application using ASP.NET Core Web API, Entity Framework Core, and Azure SQL Database, with a dynamic frontend UI inspired by Flipkart. The application is fully deployed on Azure App Service and supports product management, cart functionality, and order processing.

🚀 Live Application

Frontend UI:

https://ecommerce0809-xxxxx.azurewebsites.net/index.html


Swagger API:

https://ecommerce0809-xxxxx.azurewebsites.net/swagger





🧰 Tech Stack I Used
Backend

ASP.NET Core Web API (.NET 8)

Entity Framework Core (Code First + Migrations)

RESTful APIs

Swagger for API testing

Frontend

HTML, CSS, JavaScript

Flipkart-style card layout

Cart sidebar with dynamic total

Product search + Add to cart + Place order

Cloud & Database

Azure App Service (Deployment)

Azure SQL Database (Cloud DB)




📌 Features I Implemented

View Products in Card Layout

Add Product (Admin)

Search Products

Add to Cart (Sidebar)

Dynamic Cart Total

Place Order

Cloud-based Persistent Database

Swagger API Testing

Azure Deployment




🗄️ Database Design
Product Table

Id (Primary Key)

Name

Description

Price

Stock

Order Table

Id (Primary Key)

UserId

TotalAmount

OrderDate




⚙️ How I Run This Project Locally
1. Clone Repository
git clone https://github.com/yourusername/ecommerce-dotnet.git
cd ecommerce-dotnet

2. Configure Database

Update appsettings.json

"ConnectionStrings": {
  "DefaultConnection": "YOUR_SQL_CONNECTION_STRING"
}

3. Apply Migrations
Add-Migration Init
Update-Database

4. Run Project
dotnet run


Open:

https://localhost:xxxx/index.html




🌐 API Endpoints I Built
Product APIs

GET /api/Product → Get all products

POST /api/Product → Add product

PUT /api/Product/{id} → Update product

DELETE /api/Product/{id} → Delete product

Order APIs

GET /api/Order → Get all orders

POST /api/Order → Place order





☁️ Azure Deployment 

Created Azure App Service

Created Azure SQL Database

Configured connection string

Ran EF Core migrations on Azure

Published project from Visual Studio

Application is live and accessible publicly

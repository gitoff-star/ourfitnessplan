##### Blog Outfitnessfplan Admin Panel and Blog Application <br><br>
This repository contains the Blog Outfitnessfplan Admin Panel and Blog Application developed using Visual Studio, ASP.NET Core, C#, Bootstrap, JavaScript, CSS, HTML, and SQL Server. The project aims to provide a comprehensive admin panel for managing blog posts and categories, along with a user-friendly blog application for publishing and viewing blog content related to fitness and health.

### Features<br><br>
## Admin Panel<br><br>
Secure login and authentication system for admin users.<br><br>
Manage blog posts, including creating, editing, and deleting posts.<br><br>
Categorize blog posts under different categories for easy navigation.<br><br>
View and manage user comments on blog posts.<br><br>
Track user engagement and statistics for the blog application.<br><br>
## Blog Application<br><br>
Browse and read fitness and health-related blog posts.<br>
Filter blog posts by categories.<br>
Leave comments and engage with other users' comments.<br>
Share blog posts on social media platforms.<br>
####  Technologies Used<br><br>
Visual Studio<br>
ASP.NET Core with C#<br>
Bootstrap<br>
JavaScript<br>
CSS<br>
HTML<br>
SQL Server<br>
## Getting Started<br><br>
Follow the steps below to set up the project locally on your machine:<br>

Clone the repository to your local machine.<br>
<br>
bash<br>
Copy code<br>
git clone https://github.com/yourusername/outfitnessfplan.git<br>
### Open the solution in Visual Studio.<br>

Install the required NuGet packages and dependencies.<br>
<br>
Set up the connection string for the SQL Server database in the appsettings.json file.<br>

Run the Entity Framework Core migration to create the database schema.<br>

bash<br>
Copy code<br>
dotnet ef database update<br>
Build and run the project.
<br>
Access the admin panel by navigating to the appropriate URL and logging in with your admin credentials.<br>
<br>
Explore the blog application to read and interact with blog posts.<br>

#### API Endpoints<br><br>
The following API endpoints are available:<br>

GET /api/blogposts: Get a list of all blog posts.<br>
GET /api/blogposts/{id}: Get a specific blog post by its ID.<br>
POST /api/blogposts: Create a new blog post.<br>
PUT /api/blogposts/{id}: Update an existing blog post by its ID.<br>
DELETE /api/blogposts/{id}: Delete a blog post by its ID.<br>
GET /api/categories: Get a list of all blog post categories.<br>
POST /api/categories: Create a new blog post category.<br>
PUT /api/categories/{id}: Update an existing blog post category by its ID.<br>
DELETE /api/categories/{id}: Delete a blog post category by its ID.<br>
GET /api/comments: Get a list of all comments on blog posts.<br>
POST /api/comments: Create a new comment on a blog post.<br>
DELETE /api/comments/{id}: Delete a comment by its ID.<br>
Contribution<br>
Contributions to this project are welcome. Feel free to open issues, submit pull requests, or suggest new features.<br>

#### License<br>
This project is licensed under the MIT License.<br>
<br>

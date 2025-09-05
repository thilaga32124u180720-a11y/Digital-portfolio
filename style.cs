/* Reset and base styles */  
* {  
  margin: 0;  
  padding: 0;  
  box-sizing: border-box;  
  font-family: 'Poppins', sans-serif;  
}  
  
body {  
  background: #fff8f0;  
  color: #333;  
  line-height: 1.6;  
}  
  
h1, h2, h3 {  
  font-family: 'Lobster', cursive;  
}  
  
/* Header */  
header {  
  background: linear-gradient(90deg, #7e57c2, #9575cd); /* purple gradient */  
  color: white;  
  padding: 20px;  
  text-align: center;  
}  
  
header h1 {  
  margin-bottom: 10px;  
  font-size: 2.5rem;  
}  
  
nav {  
  margin-top: 10px;  
}  
  
nav a {  
  margin: 0 15px;  
  color: white;  
  text-decoration: none;  
  font-weight: bold;  
  font-family: 'Poppins', sans-serif;  
}  
  
nav a:hover {  
  color: #4a148c;  
  text-decoration: underline;  
}  
  
/* Buttons */  
.btn {  
  display: inline-block;  
  margin-top: 15px;  
  background: #7e57c2;  
  color: white;  
  padding: 12px 25px;  
  text-decoration: none;  
  border-radius: 5px;  
  transition: background 0.3s;  
}  
  
.btn:hover {  
  background: #512da8;  
}  
  
/* General Section */  
.section {  
  padding: 60px 20px;  
  text-align: center;  
}  
  
.section h2 {  
  font-size: 2.5rem;  
  color: #512da8; /* dark purple */  
  margin-bottom: 20px;  
}  
  
.section p {  
  max-width: 800px;  
  margin: 0 auto 20px auto;  
}  
  
/* Skills Section List */  
#skills ul {  
  list-style-type: none;  
  max-width: 400px;  
  margin: 0 auto;  
  padding: 0;  
}  
  
#skills li {  
  background: #ede7f6;  
  margin: 10px 0;  
  padding: 10px;  
  border-radius: 5px;  
  font-weight: 600;  
  color: #4a148c;  
}  
  
/* Menu Grid */  
.menu-grid {  
  display: grid;  
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));  
  gap: 30px;  
  margin-top: 30px;  
  padding: 0 20px;  
}  
  
.card {  
  background: #f3e5f5; /* light lavender */  
  border-radius: 10px;  
  overflow: hidden;  
  box-shadow: 0 4px 6px rgba(0,0,0,0.1);  
  transition: transform 0.3s;  
}  
  
.card:hover {  
  transform: scale(1.03);  
}  
  
.card img {  
  width: 100%;  
  height: 180px;  
  object-fit: cover;  
}  
  
.card h3 {  
  margin: 10px 0;  
  color: #4a148c; /* deep purple */  
}  
  
.card p {  
  padding: 0 10px 20px;  
  color: #333;  
}  
  
/* Filter Buttons */  
.filter-buttons {  
  margin-bottom: 20px;  
}  
  
.filter-buttons button {  
  background: #7e57c2;  
  border: none;  
  color: white;  
  padding: 10px 20px;  
  margin: 5px;  
  border-radius: 5px;  
  cursor: pointer;  
  font-weight: bold;  
  transition: background 0.3s;  
}  
  
.filter-buttons button:hover {  
  background: #512da8;  
}  
  
/* Contact Section */  
.contact {  
  background: #ede7f6;  
  padding-bottom: 80px;  
}  
  
.contact-btn {  
  background: #7e57c2;  
  color: white;  
  padding: 12px 25px;  
  border: none;  
  border-radius: 5px;  
  cursor: pointer;  
  font-weight: bold;  
  transition: background 0.3s;  
}  
  
.contact-btn:hover {  
  background: #512da8;  
}  
  
.contact input,  
.contact textarea {  
  width: 100%;  
  max-width: 400px;  
  padding: 10px;  
  margin-bottom: 15px;  
  border: 1px solid #ccc;  
  border-radius: 5px;  
  font-family: 'Poppins', sans-serif;  
  font-size: 1rem;  
}  
  
/* Footer */  
footer {  
  text-align: center;  
  padding: 20px;  
  background: #4a148c;  
  color: white;  
}

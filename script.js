function filterItems(category) {  
  const cards = document.querySelectorAll('.card');  
  
  cards.forEach(card => {  
    card.style.transition = 'opacity 0.4s ease, transform 0.4s ease';  
    if (category === 'all' || card.classList.contains(category)) {  
      card.style.display = 'block';  
      setTimeout(() => {  // allow transition to take effect
        card.style.opacity = '1';  
        card.style.transform = 'scale(1)';  
      }, 10);
    } else {  
      card.style.opacity = '0';  
      card.style.transform = 'scale(0.95)';  
      setTimeout(() => {  
        card.style.display = 'none';  
      }, 400);  
    }  
  });  
}  

// Optional: Prevent default form submission and show alert
document.getElementById('contactForm').addEventListener('submit', function(event) {
  event.preventDefault();
  alert('Thank you for your message! I will get back to you soon.');
  this.reset();
});

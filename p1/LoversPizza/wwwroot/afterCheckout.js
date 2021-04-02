document.getElementById('again').addEventListener('click', () => {
    location = "menu.html";
});

document.getElementById('bye').addEventListener('click', () => {
    localStorage.removeItem("customer");
    localStorage.removeItem("customerId");
    location = "index.html";
});
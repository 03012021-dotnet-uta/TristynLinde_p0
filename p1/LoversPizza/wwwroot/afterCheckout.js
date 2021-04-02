document.getElementById('again').addEventListener('click', () => {
    location = "menu.html";
});

document.getElementById('past').addEventListener('click', () => {
    localStorage.removeItem("customer");
    localStorage.removeItem("customerId");
    location = "index.html";
});
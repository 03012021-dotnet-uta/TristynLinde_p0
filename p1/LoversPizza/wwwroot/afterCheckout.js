document.getElementById('again').addEventListener('click', () => {
    location = "menu.html";
});

document.getElementById('past').addEventListener('click', () => {
    localStorage.delete("customer");
    localStorage.delete("customerId");
    location = "index.html";
});
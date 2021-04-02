let orderId = localStorage.getItem('currOrderId');
let orderBooks = JSON.parse(localStorage.getItem('orderBooks'));

let customer = JSON.parse(localStorage.getItem('customer'));
let custName = customer.fname + " " + customer.lname;

// auto fill name input using current customer
document.getElementById('name').value = custName;

for (let i = 0; i < orderBooks.length; i+= 1)
{
    // create html that takes info from localStorage
    let html = "<div class=\"book\"";
    let title = orderBooks[i].title;
    let author = orderBooks[i].author;
    let price = orderBooks[i].price.toFixed(2);

    html += `id="${i}"><p id="amt${i}">1</p><h4>${title}</h4><p class="author">${author}</p><p class="price">\$${price}</p></div>`;

    for (let j = 0; j < i; j++)
    {
        // check to see if the book is a repeat
        let prevtitle = orderBooks[j].title;
        let prevauthor = orderBooks[j].author;

        if (prevtitle == title && prevauthor == author)
        {
            // Increment the amount variable and don't print the repeated book info
            let bookAmount = parseInt(document.getElementById(`amt${j}`).innerHTML);
            bookAmount += 1;

            document.getElementById(`amt${j}`).innerHTML = bookAmount;
            html = "";
        }
    }

    document.getElementById('books').innerHTML += html;
}

// print total price and set it to 2 decimal places
let totPrice = JSON.parse(localStorage.getItem('currOrder')).price.toFixed(2);

document.querySelector('.cart').innerHTML += `<p>\$${totPrice}</p>`;

document.getElementById('checkoutinfo').addEventListener('submit', (event) => {
    event.preventDefault();

    localStorage.delete("currOrder");
    localStorage.delete("currOrderId");
    localStorage.delete("orderBooks");
    location = 'afterCheckout.html';
});
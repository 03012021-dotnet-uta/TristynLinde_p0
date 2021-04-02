let orderId = localStorage.getItem('currOrderId');
let orderBooks = JSON.parse(localStorage.getItem('orderBooks'));

for (i = 0; i < orderBooks.length; i+= 1)
{
    let html = "<div class=\"book\"";
    let title = orderBooks[i].title;
    let author = orderBooks[i].author;
    let summary = orderBooks[i].summary;
    let price = orderBooks[i].price.toFixed(2);

    html += `id="${i}"><h4>${title}</h4><p class="author">${author}</p><p class="price">\$${price}</p><p class="summary">${summary}</p></div>`;
    document.getElementById('books').innerHTML += html;
}

let totPrice = JSON.parse(localStorage.getItem('currOrder')).price.toFixed(2);

document.querySelector('.cart').innerHTML += `<p>\$${totPrice}</p>`

// // populate the html with info from db
// fetch(`api/Lovers/cart/${orderId}`)
// .then (response => {
//     if (!response.ok) {
//         throw new Error(`Network response was not ok (${response.status})`);
//     }
//     else       // When the page is loaded convert it to text
//         return response.json();
// })
// .then ((jsonResponse) => {
//     console.log(jsonResponse);
//     return jsonResponse;
// })
// .then(res => {
    
// })
// .catch(function(err) {  
//       console.log('Failed to fetch page: ', err);  
// });

document.getElementById("checkoutbutt").addEventListener('click', () => {
    location = 'checkout.html';
});

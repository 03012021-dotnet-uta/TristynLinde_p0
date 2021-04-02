let menu = document.querySelector('.menu');
let bookList;
let orderBooks = [];

console.log(localStorage.getItem('customer'));

// populate the html with info from db
fetch('api/Lovers/menu')
.then (response => {
    if (!response.ok) {
        throw new Error(`Network response was not ok (${response.status})`);
    }
    else       // When the page is loaded convert it to text
        return response.json();
})
.then ((jsonResponse) => {
    return jsonResponse;
})
.then(res => {
    bookList = res;
    for (i = 0; i < res.length; i+= 1)
    {
        let html = "<div class=\"book\"";
        let title = res[i].title;
        let author = res[i].author;
        let summary = res[i].summary;
        let price = res[i].price.toFixed(2);

        html += `id="${i}"><h4>${title}</h4><p class="author">${author}</p><p class="price">\$${price}</p><p class="summary">${summary}</p><p class="added" id="added${i}" style="display: none;">Added to Order</p><br></div><hr>`;
        menu.innerHTML += html;
        var button = document.createElement("button");
        button.appendChild(document.createTextNode("Add to Order"));
        document.getElementById(`${i}`).appendChild(button);
    }
})
.catch(function(err) {  
      console.log('Failed to fetch page: ', err);  
});

// create new order
document.getElementById('stores').addEventListener('submit', (event) => {
    event.preventDefault();

    event.target.parentElement.parentElement.style.display = "none";

    let store = document.querySelector('input[name="store"]:checked').value;
    let custId = localStorage.getItem("customerId");

    console.log(store);

    fetch(`api/Lovers/order/${custId}/${store}`)
    .then (response => {
        if (!response.ok) {
            throw new Error(`Network response was not ok (${response.status})`);
        }
        else       // When the page is loaded convert it to text
            return response.json();
    })
    .then ((jsonResponse) => {
        console.log(jsonResponse);
        return jsonResponse;
    })
    .then (res => {
        let order = JSON.stringify(res);
        localStorage.setItem('currOrder', order);// this is available to the whole browser
        localStorage.setItem('currOrderId', res.orderId);
        console.log(localStorage.getItem('currOrder'));
        console.log(localStorage.getItem('currOrderId'));
    })
    .catch(function(err) {  
        console.log('Failed to fetch page: ', err);  
    });
});

menu.addEventListener('click', (event) => {
    if (event.target.type == "submit")
    {
        let orderId = localStorage.getItem('currOrderId');
        let clicked = parseInt(event.target.parentElement.id);
        let bookId = bookList[clicked].bookId;
        orderBooks.push(bookList[clicked]);

        document.getElementById(`added${clicked}`).style.display = "inline-block";
        setTimeout(() => document.getElementById(`added${clicked}`).style.display = "none", 1500);

        fetch(`api/Lovers/update/${orderId}/${bookId}`)
        .then (response => {
            if (!response.ok) {
                throw new Error(`Network response was not ok (${response.status})`);
            }
            else       // When the page is loaded convert it to text
                return response.json();
        })
        .then ((jsonResponse) => {
            console.log(jsonResponse);
            return jsonResponse;
        })
        .then (res => {
            let order = JSON.stringify(res);
            var myBooks = JSON.stringify(orderBooks);
            localStorage.setItem('currOrder', order);// this is available to the whole browser
            localStorage.setItem('orderBooks', myBooks);
            console.log(localStorage.getItem('orderBooks'));
            console.log(localStorage.getItem('currOrder'));
        })
        .catch(function(err) {  
            console.log('Failed to fetch page: ', err);  
        });
    }
});

document.getElementById("cartbutt").addEventListener('click', () => {
    location = 'cart.html';
});
let menu = document.querySelector('.menu');
let bookList;

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
    console.log(jsonResponse);
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

        html += `id="${i}"><h4>${title}</h4><p class="author">${author}</p><p class="price">\$${price}</p><p class="summary">${summary}</p></div>`;
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

    event.target.parentElement.style.display = "none";

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
        localStorage.setItem('currOrder', res);// this is available to the whole browser
        sessionStorage.setItem('currOrder', res);// this is ony vailable to the certain window tab.
        localStorage.setItem('currOrderId', res.orderId);// this is available to the whole browser
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

        console.log(orderId + " " + bookId);

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
            localStorage.setItem('currOrder', res);// this is available to the whole browser
            sessionStorage.setItem('currOrder', res);// this is ony vailable to the certain window tab.
        })
        .catch(function(err) {  
            console.log('Failed to fetch page: ', err);  
        });
    }
});
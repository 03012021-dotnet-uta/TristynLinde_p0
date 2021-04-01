let menu = document.querySelector('.menu');

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
    for (i = 0; i < res.length; i+= 1)
    {
        let html = "<div class=\"book\"";
        let title = res[i].title;
        let author = res[i].author;
        let summary = res[i].summary;
        let price = res[i].price;

        html += `id="book${i}"><h4>${title}</h4><p class="author">${author}</p><p class="price">\$${price}</p><p class="summary">${summary}</p></div>`;
        menu.innerHTML += html;
        var button = document.createElement("button");
        button.appendChild(document.createTextNode("Add to Order"));
        document.getElementById(`book${i}`).appendChild(button);
    }
})
.catch(function(err) {  
      console.log('Failed to fetch page: ', err);  
});
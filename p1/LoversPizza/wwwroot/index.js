let loginForm = document.getElementById('user-info');

loginForm.addEventListener('submit', (event) => {
    event.preventDefault();

    const Username = loginForm.username.value.trim();
    const Password = loginForm.password.value.trim();

    fetch(`api/Lovers/login/${Username}/${Password}`)
    .then(response => {
        if (!response.ok) {
          throw new Error(`Network response was not ok (${response.status})`);
        }
        else       // When the page is loaded convert it to text
          return response.json();
      })
      .then((jsonResponse) => {
        console.log(jsonResponse);
        return jsonResponse;
      })
      .then(res => {
        //save the Person to localStorage
        localStorage.setItem('customerId', res.customerId);
        sessionStorage.setItem('customerId', res.customerId);
        //switch the screen
        location = 'menu.html';
      })
      .catch(function(err) {  
          console.log('Failed to fetch page: ', err);  
      });
});
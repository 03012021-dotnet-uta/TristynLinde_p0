let loginForm = document.getElementById('user-info');

loginForm.addEventListener('input', (event) => {
  loginForm.password.setCustomValidity("");
});

loginForm.addEventListener('submit', (event) => {
    event.preventDefault();

    const Username = loginForm.username.value.trim();
    const Password = loginForm.password.value.trim();

    fetch(`api/Lovers/login/${Username}/${Password}`)
    .then(response => {
        if (!response.ok) {
          loginForm.password.setCustomValidity("Username or Password is Incorrect");
          loginForm.password.reportValidity(); // Shows the popup bubble

          throw new Error(`Network response was not ok (${response.status})`);
        }
        else
        {
          return response.json();
        }
      })
      .then((jsonResponse) => {
        return jsonResponse;
      })
      .then(res => {
        //save the customer to localStorage
        let cust = JSON.stringify(res);
        localStorage.setItem('customer', cust);
        localStorage.setItem('customerId', res.customerId);
        //switch the screen
        location = 'menu.html';
      })
      .catch(function(err) {  
          console.log('Failed to fetch page: ', err);  
      });
});
const url = "https://localhost:44321/api/empresa/1"
//https://pokeapi.co/api/v2/pokemon
fetch(url,
    {
        mode: "no-cors",
    }
)
.then(response => response.json())
.then(data => {
   let test = document.getElementById("test")
   test.innerHTML = `<p>${data.nombre}</p>`;

   console.log(data)
})
.catch(err => console.log(err))
    
function HideAndShowFilters(){
  const additionalFilters = document.getElementById("additional-filters");

  jQuery.easing.def = "easeInCubic";
  let duration = 400;
  if (additionalFilters.getAttribute("data-open") == "0") {
    // additionalFilters.style.display = "grid";
    $(additionalFilters).slideDown(duration, "swing");
    additionalFilters.setAttribute("data-open", "1");
  } else {
    // additionalFilters.style.display = "none";
    $(additionalFilters).slideUp(duration, "swing");
    additionalFilters.setAttribute("data-open", "0");
  }
}

function OpenBookDetailed(element){
  let isbn = element.getAttribute("data-isbn");
  open("./konyveink/"+isbn, "_self");
}

function applyFilters(){
  const currentUrl = new URL(window.location);

  currentUrl.searchParams.delete("page_number");


  if(document.getElementById("title").value!=""){
      // extra+= "title="+document.getElementById("title").value+"&";
      currentUrl.searchParams.set("title", document.getElementById("title").value);
  }else{
      currentUrl.searchParams.delete("title");
  }

  if(document.getElementById("genre-select").value!=""){
      // extra+= "genre="+document.getElementById("genre-select").value+"&";
      currentUrl.searchParams.set("genre", document.getElementById("genre-select").value);
  }else{
      currentUrl.searchParams.delete("genre");
  }

  if(document.getElementById("author").value!=""){
      // extra+= "author="+document.getElementById("author").value+"&";
      currentUrl.searchParams.set("author", document.getElementById("author").value);   
  }else{
      currentUrl.searchParams.delete("author");
  }

  if(document.getElementById("date").value!=""){
      // extra+= "release_date="+document.getElementById("date").value+"&";
      currentUrl.searchParams.set("release_date", document.getElementById("date").value);
  }else{
      currentUrl.searchParams.delete("release_date");
  }

  if(document.getElementById("lang-select").value!=""){
      // extra+= "lang="+document.getElementById("lang-select").value+"&";
      currentUrl.searchParams.set("lang", document.getElementById("lang-select").value);
  }else{
      currentUrl.searchParams.delete("lang");
  }

  if(document.getElementById("ISBN").value!=""){
      // extra+= "ISBN="+document.getElementById("ISBN").value+"&";
      currentUrl.searchParams.set("ISBN", document.getElementById("ISBN").value);
  }else{
      currentUrl.searchParams.delete("ISBN");
  }

  window.history.pushState({}, "", currentUrl);

  UpdateResults();
}

   

function UpdateResults(){
  const currentUrl = new URL(window.location);


  $.ajax({
  url: "../BACKEND/api.php",
  type: "get", //send it through get method
  data: { 
      title: currentUrl.searchParams.get("title"), 
      genre: currentUrl.searchParams.get("genre"), 
      author: currentUrl.searchParams.get("author"),
      release_date: currentUrl.searchParams.get("release_date"), 
      lang: currentUrl.searchParams.get("lang"), 
      ISBN: currentUrl.searchParams.get("ISBN"),
      page_number: currentUrl.searchParams.get("page_number")==null?1:currentUrl.searchParams.get("page_number")
  },
  success: function(response)  {
      document.getElementById("results").innerHTML = response; 
  }
  });

  window.scroll(0,0);
}


function NavigateToNextOrPreviousPage(direction){
  if(direction == 1 || direction == -1){
      const currentUrl = new URL(window.location);
      const currentPageNumber = currentUrl.searchParams.get("page_number")==null?1:currentUrl.searchParams.get("page_number")*1;

      let newPageNumber = Math.max(currentPageNumber+direction, 0);
      

      if(newPageNumber == 1){
          currentUrl.searchParams.delete("page_number");
      }else{
          currentUrl.searchParams.set("page_number", newPageNumber);
      }
      
      window.history.pushState({}, '', currentUrl);

      UpdateResults();
  }
}



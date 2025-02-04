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



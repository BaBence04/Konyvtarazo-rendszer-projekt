window.addEventListener("load", () => {
    const loader = document.querySelector(".loading-screen");
  
    loader.classList.add("loading-screen-hidden");
  
    loader.addEventListener("transitionend", () => {
      document.body.removeChild(loader);
    });



    /* animations on load */


/*     const heroImage = document.querySelector('.hero-image');
    heroImage.classList.add('zoom-out'); */
});
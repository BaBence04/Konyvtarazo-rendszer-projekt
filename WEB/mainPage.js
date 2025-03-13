document.addEventListener("DOMContentLoaded", function() {
    gsap.registerPlugin(ScrollTrigger);

    const lenis = new Lenis({
        lerp: 0.08,
        duration: 0.3,
        smooth: true,
    });

    lenis.on("scroll", ScrollTrigger.update);

    gsap.ticker.add((time ) => {
        lenis.raf(time * 200);
    })

    gsap.ticker.lagSmoothing(0)

    gsap.registerPlugin(ScrollTrigger);

    const image = document.querySelector(".image-wrapper img");

    gsap.fromTo(
        image,
        {
        clipPath: "inset(25% 25% 25% 25%)",
        scale: 1,
        },
        {
            clipPath: "inset(0% 0% 0% 0%)",
            scale: 1.1,
            scrollTrigger: {
                trigger: ".ws",
                start: "top bottom",
                end: "bottom center",
                scrub: 0,
                /* pin: true, */
                duration: true,
            },
        }
    );


    gsap.fromTo(
        ".text-toLeft", 
        {
          /* opacity: 0, */
          x: 0,
        },
        {
          /* opacity: 1, */
          x: "-10vw",
          scrollTrigger: {
            trigger: ".outro",
            start: "top bottom",
            end: "bottom center",
            scrub: true, 
          }
        }
      );
      
      gsap.fromTo(
        ".text-toRight",
        {
          /* opacity: 0, */
          x: 0,
        },
        {
          /* opacity: 1, */
          x: "10vw",
          scrollTrigger: {
            trigger: ".outro",
            start: "top bottom", 
            end: "bottom center",
            scrub: true,
          }
        }
      );

    ScrollTrigger.create({
        trigger: ".ws",
        start: "top bottom",
        end: "bottom bottom",
        scrub: 0,
        onUpdate: (self) => {
            const galleryWrapper = document.querySelector(".gallery-wrapper");
            const sideCols = document.querySelectorAll(".col:not(.main)");
            //const mainImg = document.querySelector(".img.main img");

            const scale = 1+ self.progress * 2.65;
            const yTranslate = self.progress * 300;
            //const mainImgScale = 2 - self.progress * 80;

            galleryWrapper.style.transform = `translate(-50%, -50%) scale(${scale})`;

            sideCols.forEach((col) => {
                col.style.transform = `translateY(${yTranslate}px)`;
            });   
            
            /*if (mainImg) {
                mainImg.style.transform = `scale(${mainImgScale})`;
            } */

            /*             if (self.progress === 1) {
                requestAnimationFrame(() => {
                    image.style.transform = "translateZ(0)"; 
                });
            } */


        },
    });


    if (navigator.userAgent.toLowerCase().includes("chrome")) {
        document.body.classList.add("chrome-browser");
    }




});






// NAVBAR TEXT COLOR CHANGER


document.addEventListener("DOMContentLoaded", function() {
  const navbarLinks = document.querySelectorAll('a.nav__link');
  const logoLink = document.getElementById("logo_text");
  
  function getBackgroundBrightness(element) {
    const bgColor = window.getComputedStyle(element).backgroundColor;
    const rgb = bgColor.match(/\d+/g).map(Number);

    const brightness = 0.2126 * rgb[0] + 0.7152 * rgb[1] + 0.0722 * rgb[2];
    return brightness;
  }

  function updateNavbarTextColor() {
    const width = window.innerWidth;

    const sections = document.querySelectorAll('.section');
    const navLinkRect = navbarLinks[0].getBoundingClientRect();
    let currentSection = null;

    const userIcon = document.getElementById("user_icon");
    const menuIcon = document.getElementById("menu_icon");


    

    sections.forEach((section) => {
      const sectionRect = section.getBoundingClientRect();

      if (
        (sectionRect.top <= navLinkRect.top && sectionRect.bottom >= navLinkRect.top) ||
        (sectionRect.top <= navLinkRect.bottom && sectionRect.bottom >= navLinkRect.bottom)
      ) {
        currentSection = section;
      }
    });

    if (currentSection) {
      const brightness = getBackgroundBrightness(currentSection);
      if (width <= 1022) {
        navbarLinks.forEach(link => link.style.color = 'black');
        if (brightness < 128) { 
          logoLink.style.color = 'white';
          userIcon.setAttribute('fill', 'white');
          menuIcon.setAttribute('fill', 'white');
        } else { 
          logoLink.style.color = 'black';
          userIcon.setAttribute('fill', 'black');
          menuIcon.setAttribute('fill', 'black');
        }
      } else {
        if (brightness < 128) { 
          navbarLinks.forEach(link => link.style.color = 'white');
          logoLink.style.color = 'white';
          userIcon.setAttribute('fill', 'white');
          menuIcon.setAttribute('fill', 'white');
        } else { 
          navbarLinks.forEach(link => link.style.color = 'black');
          logoLink.style.color = 'black';
          userIcon.setAttribute('fill', 'black');
          menuIcon.setAttribute('fill', 'black');
        }
      }

    }
  }

  window.addEventListener('scroll', updateNavbarTextColor);
  updateNavbarTextColor();
});



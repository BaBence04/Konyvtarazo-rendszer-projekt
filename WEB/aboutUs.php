<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>About Us</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Crimson+Pro:wght@200..900&display=swap">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.2/gsap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.2/ScrollTrigger.min.js"></script>

    <link rel="stylesheet" href="aboutUs.css">

</head>
<body>
<!DOCTYPE html>
<html lang="en">
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>About Us</title>
</head>
<body>
    <?php require_once "loadingScreen.html"; ?>


    <!-- Hero Section -->
    <section class="hero-section">
        <div class="hero-content">
        <div class="experience-badge">
          <img id="team_img" src="/web/imgs/team_illustration.jpg" alt="" srcset="">
        </div>
        <h1>Üdvözli Önt a csapat</h1>

        </div>
    </section>

    <!-- Team Section -->
    <section class="team-section">
        <!-- <h2>Ismerje meg csapatunkat!</h2> -->
        <div class="team-grid">
        <div class="team-member">
            <img src="/web/imgs/bence.jpg" alt="Bence" class="member-image">
            <h3>Bence</h3>
            <p class="role">Backend, SQL</p>
            <p class="description">Bence felelős a weboldalunk és asztali alkalmazásunk backend részéért.</p>
        </div>
        <div class="team-member">
            <img src="/web/imgs/balint.jpg" alt="Bálint" class="member-image">
            <h3>Bálint</h3>
            <p class="role">Backend, frontend</p>
            <p class="description">Bálint felelős a backend és frontend integrációjáért.</p>
        </div>
        <div class="team-member">
            <img src="/web/imgs/marci.jpeg" alt="Person 3" class="member-image">
            <h3>Márton</h3>
            <p class="role">Frontend, design</p>
            <p class="description">Márton felelős a project fontend és a design részéért.</p>
        </div>
        </div>
    </section>

    <!-- Mission Section -->
    <section class="mission-section">
        <div class="mission-content">
        <h2>Küldetésünk</h2>
        <p>A célunk egy komprehenzív könyvtárazó rendszer elkészítése és üzemeltetése, mely mind design és funkcionalitás szempontjából meghalad számos hasonló célokra fejlesztett rendszert. Továbbá szeretnénk, hogy nem csak felhasználók, hanem dolgozók számára is egy kényelmes és stílusos software-t készítsünk.</p>
        </div>
    </section>

    <!-- Stats Section -->
    <section class="stats-section">
        <div class="stat-item">
        <span class="stat-number">2000+</span>
        <p class="stat-label">Órányi közös munka</p>
        </div>
        <div class="stat-item">
        <span class="stat-number">2</span>
        <p class="stat-label">Közös project</p>
        </div>
        <div class="stat-item">
        <span class="stat-number">800+</span>
        <p class="stat-label">Git commit</p>
        </div>
    </section>

    <script>
        gsap.registerPlugin(ScrollTrigger);

        gsap.to(".hero h1", { opacity: 1, y: 0, duration: 1.5, delay: 0.5 });
        gsap.to(".hero::before", { left: "100%", duration: 1, delay: 0.3 });
        
        gsap.utils.toArray(".section").forEach(section => {
            gsap.to(section, {
                opacity: 1,
                y: 0,
                duration: 1,
                scrollTrigger: {
                    trigger: section,
                    start: "top 85%",
                    toggleActions: "play none none none"
                }
            });
        });
        
        gsap.to(".image", {
            opacity: 1,
            scale: 1,
            duration: 1,
            scrollTrigger: {
                trigger: ".image",
                start: "top 85%",
                toggleActions: "play none none none"
            }
        });
        
        gsap.utils.toArray(".team-member").forEach(member => {
            gsap.to(member, {
                opacity: 1,
                y: 0,
                duration: 1,
                scrollTrigger: {
                    trigger: member,
                    start: "top 90%",
                    toggleActions: "play none none none"
                }
            });
        });
    </script>
</body>
</html>

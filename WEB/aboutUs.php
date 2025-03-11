<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>About Us</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Crimson+Pro:wght@200..900&display=swap">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.2/gsap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.2/ScrollTrigger.min.js"></script>
    <style>
/* General Styles */
body {
  font-family: 'Arial', sans-serif;
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  color: #333;
}

/* Hero Section */
.hero-section {
  background: url('/web/imgs/about_us_hero.jpg') no-repeat center center/cover;
  height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
  color: white;
  text-align: center;
}

.hero-content h1 {
  font-size: 48px;
  margin-bottom: 20px;
}

.hero-content p {
  font-size: 24px;
  margin-bottom: 30px;
}

.experience-badge {
  background: rgba(255, 255, 255, 0.2);
  padding: 20px;
  border-radius: 10px;
  display: inline-block;
}

.experience-badge span {
  font-size: 60px;
  font-weight: bold;
  display: block;
}

.experience-badge p {
  font-size: 18px;
  margin: 0;
}

/* Team Section */
.team-section {
  padding: 60px 20px;
  text-align: center;
  background: url('/web/imgs/team_bg.jpg') no-repeat center center/cover;
  height: 100vh;
  align-items: center;
}

.team-section h2 {
  font-size: 36px;
  margin-bottom: 40px;
}

.team-grid {
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
}

.team-member {
  max-width: 300px;
  margin: 20px;
  opacity: 0;
  transform: translateY(20px);
  animation: fadeInUp 1s ease forwards;
}

.team-member:nth-child(1) { animation-delay: 0.2s; }
.team-member:nth-child(2) { animation-delay: 0.4s; }
.team-member:nth-child(3) { animation-delay: 0.6s; }

.member-image {
  width: 300px;
  height: 300px;
  border-radius: 50%;
  object-fit: cover;
  margin-bottom: 15px;
  transition: transform 0.3s ease;
}

.member-image:hover {
  transform: scale(1.1);
}

.role {
  font-style: italic;
  color: #777;
}

.description {
  font-size: 14px;
  line-height: 1.6;
}

/* Mission Section */
.mission-section {
  background: url('/web/imgs/mission_bg.jpg') no-repeat center center/cover;
  color: white;
  padding: 60px 20px;
  text-align: center;
  height: 50vh;
}

.mission-content {
  max-width: 800px;
  margin: 0 auto;
  background: rgba(0, 0, 0, 0.6);
  padding: 20px;
  border-radius: 10px;
}

.mission-section h2 {
  font-size: 36px;
  margin-bottom: 20px;
}

.mission-section p {
  font-size: 18px;
  line-height: 1.8;
}

/* Stats Section */
.stats-section {
  display: flex;
  justify-content: space-around;
  padding: 60px 20px;
  background: hsl(171, 85%, 26%);
  color: white;
  text-align: center;
}

.stat-item {
  max-width: 200px;
}

.stat-number {
  font-size: 48px;
  font-weight: bold;
  display: block;
}

.stat-label {
  font-size: 18px;
  margin: 0;
}

/* Footer */
footer {
  background: #333;
  color: white;
  text-align: center;
  padding: 20px 0;
}

.social-links {
  margin-bottom: 10px;
}

.social-links a {
  color: white;
  text-decoration: none;
  margin: 0 10px;
}

/* Animations */
@keyframes fadeInUp {
  to {
    opacity: 1;
    transform: translateY(0);
  }
}

    </style>
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
        <h1>Welcome to Our Team</h1>
        <p>We are a group of passionate professionals dedicated to excellence.</p>
        <div class="experience-badge">

        </div>
        </div>
    </section>

    <!-- Team Section -->
    <section class="team-section">
        <h2>Meet Our Team</h2>
        <div class="team-grid">
        <div class="team-member">
            <img src="/web/imgs/img2.jpg" alt="Person 1" class="member-image">
            <h3>Bence</h3>
            <p class="role">igen</p>
            <p class="description">John is passionate about innovation and leading our team to success.</p>
        </div>
        <div class="team-member">
            <img src="/web/imgs/img2.jpg" alt="Person 2" class="member-image">
            <h3>Bálint</h3>
            <p class="role">igen</p>
            <p class="description">Jane brings creativity and vision to every project she touches.</p>
        </div>
        <div class="team-member">
            <img src="/web/imgs/img2.jpg" alt="Person 3" class="member-image">
            <h3>Márton</h3>
            <p class="role">igen</p>
            <p class="description">Mike ensures our technology is cutting-edge and reliable.</p>
        </div>
        </div>
    </section>

    <!-- Mission Section -->
    <section class="mission-section">
        <div class="mission-content">
        <h2>Our Mission</h2>
        <p>We are dedicated to delivering exceptional solutions that empower our clients and inspire innovation. Our team works tirelessly to create meaningful experiences and drive positive change.</p>
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

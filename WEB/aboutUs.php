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
        body {
            font-family: 'Crimson Pro', serif;
            background-color: hsl(0, 0%, 96%);
            color: #333;
            margin: 0;
            padding: 0;
            overflow-x: hidden;
        }
        .container {
            width: 90%;
            max-width: 1200px;
            margin: 0 auto;
            padding: 50px 0;
        }
        .hero {
            text-align: center;
            padding: 120px 20px;
            background: hsl(171, 85%, 26%);
            color: white;
            position: relative;
            overflow: hidden;
        }
        .hero h1 {
            font-size: 3rem;
            opacity: 0;
        }
        .hero::before {
            content: '';
            position: absolute;
            width: 100%;
            height: 100%;
            top: 0;
            left: -100%;
            background: rgba(255, 255, 255, 0.1);
            transform: skewX(-30deg);
        }
        .section {
            margin: 80px 0;
            opacity: 0;
            transform: translateY(50px);
        }
        .image {
            width: 100%;
            max-width: 600px;
            display: block;
            margin: 40px auto;
            opacity: 0;
            transform: scale(0.9);
        }
        .team {
            display: flex;
            justify-content: center;
            gap: 20px;
            flex-wrap: wrap;
        }
        .team-member {
            background: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 10px 20px rgba(0, 0, 0, 0.1);
            text-align: center;
            opacity: 0;
            transform: translateY(50px);
        }
    </style>
</head>
<body>
    <div class="hero">
        <h1>About Our Library</h1>
    </div>
    <div class="container">
        <div class="section">
            <h2></h2>
            <p></p>
        </div>
        <img src="library.jpg" alt="Library" class="image">
        <div class="section">
            <h2></h2>
            <p></p>
        </div>
        <div class="team">
            <div class="team-member">
                <h3>Bence</h3>
                <p>valamit csinál</p>
            </div>
            <div class="team-member">
                <h3>Bálint</h3>
                <p>valamit csinál</p>
            </div>
            <div class="team-member">
                <h3>Marci</h3>
                <p>valamit csinál</p>
            </div>
        </div>
    </div>
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

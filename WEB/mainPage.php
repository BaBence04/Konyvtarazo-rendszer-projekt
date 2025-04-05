<body>

    <?php require_once "loadingScreen.html"; ?>
    
    <section class="sticky">
        <div class="gallery-wrapper">
            <div class="col side-1">
                <div class="img"></div>
                <div class="img"></div>
                <div class="img"></div>
            </div>
            <div class="col side-2">
                <div class="img"><img src="/web/imgs/img4.jpg" loading="lazy" alt=""></div>
                <div class="img"><img src="/web/imgs/img5.jpg" loading="lazy" alt=""></div>
                <div class="img"><img src="/web/imgs/img6.jpg" loading="lazy" alt=""></div>
            </div>
            <div class="col main">
                <div class="img"><img src="/web/imgs/img7.jpg" loading="lazy" alt=""></div>
                    <div class="image-wrapper">
                        <img src="/web/imgs/img9.jpg" alt="Revealed Image">
                    </div>
                <div class="img"><img src="/web/imgs/img8.jpg" loading="lazy"alt=""></div>
            </div>
            <div class="col side-3">
                <div class="img"><img src="/web/imgs/img10.jpg" loading="lazy" alt=""></div>
                <div class="img"><img src="/web/imgs/img11.jpg" loading="lazy" alt=""></div>
                <div class="img"><img src="/web/imgs/img12.jpg" loading="lazy" alt=""></div>
            </div>
            <div class="col side-4">
                <div class="img"></div>
                <div class="img"></div>
                <div class="img"></div>
            </div>

        </div>
    </section>
    <div class="container">
        <section class="hero section" id="hero_section">
            <div class="hero-img">
                <img src="/web/imgs/hero-image_dark(25).png" alt="">
            </div>
            <div class="header-main">
                <h1 class="header-left">BOOK</h1>
                <h1 class="header-right">HIVE</h1>
            </div>
        </section>
        <section class="intro section" id="into_section">
            <div class="tagline">
                <p>Üdvözöljük az online könytárunkban!</p>
            </div>
            <div class="divider"></div>
            <div class="intro-header">
                <!-- <img src="/web/imgs/books_line.png" alt=""> -->
                <h1>Könyvfoglalás</h1>
                <h1>egy kattingtással</h1>
            </div>
        </section>
        <section class="ws section" id="ws_section"></section>
        <section class="trans-bg-content section" id="tbg_section">
            <div class="allBoooks-service">
                <div class="service-container">
                    <img src="/web/imgs/book-icon_2.png" class="services-img">
                    <h2>Ismerje meg kínálatunkat és merüljön el a változatos mesevilágokban!</h2>
                    <a href="/web/konyveink">
                    <button class="button">
                    <span class="button__icon-wrapper">
                        <svg
                        viewBox="0 0 14 15"
                        fill="none"
                        xmlns="http://www.w3.org/2000/svg"
                        class="button__icon-svg"
                        width="10"
                        >
                        <path
                            d="M13.376 11.552l-.264-10.44-10.44-.24.024 2.28 6.96-.048L.2 12.56l1.488 1.488 9.432-9.432-.048 6.912 2.304.024z"
                            fill="currentColor"
                        ></path>
                        </svg>

                        <svg
                        viewBox="0 0 14 15"
                        fill="none"
                        width="10"
                        xmlns="http://www.w3.org/2000/svg"
                        class="button__icon-svg button__icon-svg--copy"
                        >
                        <path
                            d="M13.376 11.552l-.264-10.44-10.44-.24.024 2.28 6.96-.048L.2 12.56l1.488 1.488 9.432-9.432-.048 6.912 2.304.024z"
                            fill="currentColor"
                        ></path>
                        </svg>
                    </span>
                    Könyvek böngészése
                    </button></a>
                </div>


            </div>

            <div class="team-service">
                <div class="service-container">
                    <img src="/web/imgs/team-icon.png" class="services-img">
                    <h2>Kukkantson be a színfalak mögé és ismerje meg csapatunkat!</h2>
                    <a href="/web/rolunk">
                    <button class="button">
                    <span class="button__icon-wrapper">
                        <svg
                        viewBox="0 0 14 15"
                        fill="none"
                        xmlns="http://www.w3.org/2000/svg"
                        class="button__icon-svg"
                        width="10"
                        >
                        <path
                            d="M13.376 11.552l-.264-10.44-10.44-.24.024 2.28 6.96-.048L.2 12.56l1.488 1.488 9.432-9.432-.048 6.912 2.304.024z"
                            fill="currentColor"
                        ></path>
                        </svg>

                        <svg
                        viewBox="0 0 14 15"
                        fill="none"
                        width="10"
                        xmlns="http://www.w3.org/2000/svg"
                        class="button__icon-svg button__icon-svg--copy"
                        >
                        <path
                            d="M13.376 11.552l-.264-10.44-10.44-.24.024 2.28 6.96-.048L.2 12.56l1.488 1.488 9.432-9.432-.048 6.912 2.304.024z"
                            fill="currentColor"
                        ></path>
                        </svg>
                    </span>
                    Megismerkedés a csapatunkkal
                    </button></a>
                </div>
            </div>

            <div class="login-service">
                <div class="service-container">
                    <img src="/web/imgs/login-icon.png" class="services-img">
                    <h2>Jelentkezzen be, hogy hozzáférjen az összes funkcióhoz!</h2>
                    <button href="#" class="button" onclick="ShowLoginOrOpenUserDetailed();">
                    <span class="button__icon-wrapper">
                        <svg
                        viewBox="0 0 14 15"
                        fill="none"
                        xmlns="http://www.w3.org/2000/svg"
                        class="button__icon-svg"
                        width="10"
                        >
                        <path
                            d="M13.376 11.552l-.264-10.44-10.44-.24.024 2.28 6.96-.048L.2 12.56l1.488 1.488 9.432-9.432-.048 6.912 2.304.024z"
                            fill="currentColor"
                        ></path>
                        </svg>

                        <svg
                        viewBox="0 0 14 15"
                        fill="none"
                        width="10"
                        xmlns="http://www.w3.org/2000/svg"
                        class="button__icon-svg button__icon-svg--copy"
                        >
                        <path
                            d="M13.376 11.552l-.264-10.44-10.44-.24.024 2.28 6.96-.048L.2 12.56l1.488 1.488 9.432-9.432-.048 6.912 2.304.024z"
                            fill="currentColor"
                        ></path>
                        </svg>
                    </span>
                    Bejelentkezés / Fiók
                    </button>
                </div>
            </div>
        </section>
        <section class="outro section" id="outro_section">
            <h1 class="text-toLeft">“There is no friend </h1>
            <h1 class="text-toRight">as loyal as a book.”</h1>
            <p><i>– Ernest Hemingway</i></p>
        </section>
        <?php require_once "footer.html"; ?>
    </div>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.5/gsap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.5/ScrollTrigger.min.js"></script>
    <script src="https://unpkg.com/lenis@1.1.19/dist/lenis.min.js"></script>
    
    <script src="mainPage.js"></script>
    

    
</body>
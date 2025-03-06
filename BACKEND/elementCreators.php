<?php
    // require_once "databaseFunctions.php";
    function CreateBookElement($data):string{
        $result = "
            <div class='grid-item' data-isbn='$data[ISBN]' onclick='OpenBookDetailed(this);'>
                <img src='".$data["picture_base64"]."' alt='".$data["title"]." könyv borítóképe'>
                <div class='book-title'>".$data["title"]."</div>
                <div class='book-author'>".str_replace(",",", ",$data["authors"])."</div>

                <div class='book-genres'>".str_replace(",",", ",$data["genres"])."</div>

                <label class='ui-like'>
                    <input type='checkbox' class='like-input'>
                    <div class='like'>
                    <svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' fill=''><g stroke-width='0' id='SVGRepo_bgCarrier'></g><g stroke-linejoin='round' stroke-linecap='round' id='SVGRepo_tracerCarrier'></g><g id='SVGRepo_iconCarrier'><path d='M20.808,11.079C19.829,16.132,12,20.5,12,20.5s-7.829-4.368-8.808-9.421C2.227,6.1,5.066,3.5,8,3.5a4.444,4.444,0,0,1,4,2,4.444,4.444,0,0,1,4-2C18.934,3.5,21.773,6.1,20.808,11.079Z'></path></g></svg>
                    </div>
                </label>
            </div>
        ";

        return $result;
    }

    function create_listed_books_elements($title, $genre, $author, $release_date, $lang, $isbn, $page) : string {
        global $results_per_page;
        $resultHTML="";
        // $data = GetBooksFiltered($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["isbn"]);
        $data = get_books_filtered($title,$genre,$author,$release_date,$lang,$isbn, $page);
        $number_of_results = get_books_filtered_number_of_results($title,$genre,$author,$release_date,$lang,$isbn);
        
        $last_possible_page = ceil($number_of_results/$results_per_page);

        $resultHTML.="<div class='content_container grid-container'>";
        for ($i=0; $i < count($data); $i++) { 
            $resultHTML.=CreateBookElement($data[$i]);
        }
        if(count($data)==0){
            if($last_possible_page<$page && $page != 1){
                $resultHTML.= "<h3>Nincs ennyi oldalnyi találat!</h3>";
            }else{
                $resultHTML.= "<h3>Ilyen feltételekkel nem találtunk könyvet</h3>";
            }
        }

        $resultHTML.="</div>";
        $resultHTML.="<div class='page_button_holder'>";
        if($page>1){
            $resultHTML.= "<input type='button' value='Előző' onclick='NavigateToNextOrPreviousPage(-1);'>";

        }else{
            $resultHTML.="<p></p>";
        }
        $resultHTML.="<p id='currentPage' class='page_button'>$page</p>";

        if($page<$last_possible_page){
            $resultHTML.= "<input type='button' value='Következő' onclick='NavigateToNextOrPreviousPage(1);'>";
        }else{
            $resultHTML.="<p></p>";
        }

        $resultHTML.="</div>";
        return $resultHTML;
    }

    function CreateGenreFilter($selected_genre): string{
        $resultHTML = '<div class="genre-filter">
        <label for="genre-select" class="filter-label">Szűrés műfaj szerint</label>
        <select id="genre-select" class="genre-select">
            <option value="">Összes műfaj</option>';
        $data = GetGenres();
        for ($i=0; $i < count($data); $i++) {
            $selected = $data[$i]['genre'] == $selected_genre?"selected":"";
            $resultHTML .= '<option value="'.$data[$i]['genre'].'" '.$selected.'>'.$data[$i]['genre'].'</option>';
        }
        $resultHTML .= '</select>
        </div>';
        return $resultHTML;
    }

    function CreateLanguageFilter($selected_lang): string{
        $resultHTML = '<div class="lang-filter">
        <label for="lang-select" class="filter-label">Megjelenési nyelv</label>
        <select id="lang-select" class="lang-select">
            <option value="">Összes nyelv</option>';
        $data = GetLangs();
        for ($i=0; $i < count($data); $i++) { 
            $selected = ($data[$i]['lang'] == $selected_lang)?"selected":"";
            $resultHTML .= '<option value="'.$data[$i]['lang'].'"'.$selected.'>'.$data[$i]['lang'].'</option>';
        }
        $resultHTML .= '</select>
        </div>';
        return $resultHTML;
    }
?>
<?php
    require_once "databaseFunctions.php";
    function CreateBookElement($data):string{
        $result = "
            <div class='grid-item' onclick=window.location='bookDetailed.php?ISBN=".$data['ISBN']."'; data-isbn='".$data["ISBN_id"]."'>
                <img src='".$data["picture_base64"]."' alt='".$data["title"]." könyv borítóképe'>
                <div class='book-title'>".$data["title"]."</div>
                <div class='book-author'>".str_replace(",",", ",$data["authors"])."</div>
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

    function CreateGenreFilter(): string{
        $resultHTML = '<div class="genre-filter">
        <label for="genre-select" class="filter-label">Szűrés műfaj szerint</label>
        <select id="genre-select" class="genre-select">
            <option value="">Összes műfaj</option>';
        $data = GetGenres();
        for ($i=0; $i < count($data); $i++) { 
            $resultHTML .= '<option value="'.$data[$i]['genre'].'">'.$data[$i]['genre'].'</option>';
        }
        $resultHTML .= '</select>
        </div>';
        return $resultHTML;
    }

    function CreateLanguageFilter(): string{
        $resultHTML = '<div class="lang-filter">
        <label for="lang-select" class="filter-label">Megjelenési nyelv</label>
        <select id="lang-select" class="lang-select">
            <option value="">Összes nyelv</option>';
        $data = GetLangs();
        for ($i=0; $i < count($data); $i++) { 
            $resultHTML .= '<option value="'.$data[$i]['lang'].'">'.$data[$i]['lang'].'</option>';
        }
        $resultHTML .= '</select>
        </div>';
        return $resultHTML;
    }

    function CreateFilter(): string {
        $resultHTML = '<div id="filters">
            <div class="title-filter">
                <label for="title">Cím</label>
                <input type="text" id="title" value="" name="title" placeholder="pl.:  Állatfarm">
            </div>
            
            <button id="toggleFilters" type="button" onclick="HideAndShowFilters();">További szűrők</button>
            
            <div id="additional-filters" data-open="0" style="display: none;">
                ' . CreateGenreFilter() . '
                
                <div class="author-filter">
                    <label for="author">Szerző</label>
                    <input type="text" id="author" name="author" placeholder="pl.:  George Orwell">
                </div>
                
                <div class="releaseDate-filter">
                    <label for="date">Megjelenési dátum</label>
                    <input type="date" id="date" name="date">
                </div>
                
                ' . CreateLanguageFilter() . '
                
                <div class="ISBN-filter">
                    <label for="ISBN">ISBN-kód</label>
                    <input type="text" id="ISBN" name="ISBN">
                </div>
                
                
            </div>


            
            
            <input id="searchButton" type="button" onclick="applyFilters()" value="Keresés">


        </div>';
        return $resultHTML;
    }

    
    
    

?>
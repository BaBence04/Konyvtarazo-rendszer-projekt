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

    function CreateDetailedBookElement($id) : string {
        $result = "";
        $data = GetBookByIsbnId($id)[0];
        //create the html for detailed book

        return $result;
    }

    function CreateListedBooksElements($title,$genre,$author,$release_date,$lang,$isbn) : string {
        $resultHTML="";
        // $data = GetBooksFiltered($_GET["title"],$_GET["genre"],$_GET["author"],$_GET["release_date"],$_GET["lang"],$_GET["isbn"]);
        $data = GetBooksFiltered($title,$genre,$author,$release_date,$lang,$isbn);
        $resultHTML.="<div class='content_container grid-container'>";
        for ($i=0; $i < count($data); $i++) { 
            $resultHTML.=CreateBookElement($data[$i]);
        }
        if(count($data)==0){
            //feel free to modify this
            $resultHTML.= "<h3>Ilyen feltételekkel nem találtunk könyvet</h3>";
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

    function CreateFilter(): string{
        $resultHTML = '<div id="filters"> 
        <div class="title-filter">
            <label for="title">
                Cím
            </label>
            <input type="text" id="title" value="" name="title">
        </div>';
        $resultHTML.=CreateGenreFilter();
        $resultHTML.='
        <div class="author-filter">
            <label for="author">
                Szerző
            </label>
            <input type="text" id="author" name="author">
        </div>
        <div class="releaseDate-filter">
            <label for="date">
                Megjelenési dátum
            </label>
            <input type="date" id="date" name="date">
        </div>';
        $resultHTML.=CreateLanguageFilter();
        $resultHTML.='<div class="ISBN-filter">
            <label for="ISBN">
                ISBN-kód
            </label>
            <input type="text" id="ISBN" name="ISBN">
        </div>
        <input type="button" onclick="applyFilters()" value="Szűrés">
        </div>';
        return $resultHTML;
    }
    
    

?>
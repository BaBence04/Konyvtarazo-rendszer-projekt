<?php
    function CreateBookElement($data):string{
        $result = "
            <div class='grid-item' data-isbn='".$data["ISBN_id"]."'>
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

        $resultHTML.="</div>";
        return $resultHTML;
    }

?>
<div id="filters">
<div id="baseFilters">

    <div class="title-filter">
        <label for="title">Cím</label>
        <input type="text" id="title" value="<?=$title?>" name="title" placeholder="pl.:  Állatfarm" onkeyup="CheckForEnterPressedAndClickGivenButton(event, 'searchButton')" >
    </div>
    
    <button id="toggleFilters" type="button" onclick="HideAndShowFilters();">További szűrők</button>
</div>

<div id="additional-filters" data-open="0" style="display: none;">
    <?=CreateGenreFilter($genre)?>
    
    <div class="author-filter">
        <label for="author">Szerző</label>
        <input type="text" value="<?=$author ?>" id="author" name="author" placeholder="pl.:  George Orwell">
    </div>
    
    <div class="releaseDate-filter">
        <label for="date">Megjelenési dátum</label>
        <input type="date" value="<?=$release_date ?>" id="date" name="date">
    </div>
    
    <?=CreateLanguageFilter($lang)?>
    
    <div class="ISBN-filter">
        <label for="ISBN">ISBN-kód</label>
        <input type="text" value="<?=$isbn ?>" id="ISBN" name="ISBN">
    </div>
    
    
</div>




<input id="searchButton" type="button" onclick="applyFilters();" value="Keresés">


</div>
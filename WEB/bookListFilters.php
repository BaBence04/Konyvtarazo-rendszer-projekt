<div id="filters">
<div id="baseFilters">

    <div class="title-filter">
        <label for="title">Cím</label>
        <input type="text" id="title" value="" name="title" placeholder="pl.:  Állatfarm" onkeypress="SearchOnEnter(event);">
    </div>
    
    <button id="toggleFilters" type="button" onclick="HideAndShowFilters();">További szűrők</button>
</div>

<div id="additional-filters" data-open="0" style="display: none;">
    <?=CreateGenreFilter()?>
    
    <div class="author-filter">
        <label for="author">Szerző</label>
        <input type="text" id="author" name="author" placeholder="pl.:  George Orwell">
    </div>
    
    <div class="releaseDate-filter">
        <label for="date">Megjelenési dátum</label>
        <input type="date" id="date" name="date">
    </div>
    
    <?=CreateLanguageFilter()?>
    
    <div class="ISBN-filter">
        <label for="ISBN">ISBN-kód</label>
        <input type="text" id="ISBN" name="ISBN">
    </div>
    
    
</div>




<input id="searchButton" type="button" onclick="applyFilters()" value="Keresés">


</div>
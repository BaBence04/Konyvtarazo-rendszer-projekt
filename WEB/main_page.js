/* navbar script */

function select(el) {
	document.querySelector(".navsearch.active")?.classList.remove("active");
	document.querySelector(".active")?.classList.remove("active");

	el.classList.add("active");

	document.body.style.setProperty("--activeclr", el.dataset.clr);
}

function selectsearch() {
	const searchElement = document.querySelector(".navsearch");
	searchElement.classList.toggle("active");

	// Focus on the search input when activated
	if (searchElement.classList.contains("active")) {
		document.querySelector(".searchbox").focus();
	}
}
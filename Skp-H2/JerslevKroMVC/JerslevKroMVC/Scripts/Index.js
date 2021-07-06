/* Hamburger menu */
// Toggle between showing and hiding the navigation menu links when the user clicks on the hamburger menu / bar icon
function myFunction() {
    var x = document.getElementById("mylinks");
    if (x.style.display === "block") {
        x.style.display = "none";
    } else {
        x.style.display = "block";
    }
}

// Navbar sticks to the top of the scrren
const sentinelEl = document.getElementById("sentinel")
const topnavEl = document.getElementById("topnav")
const stuckClass = "stuck"

const handler = (entries) => {
    console.log(entries)
    if (topnavEl) {
        if (!entries[0].isIntersecting) {
            topnavEl.classList.add(stuckClass)
        } else {
            topnavEl.classList.remove(stuckClass)
        }
    }
}

const observer = new window.IntersectionObserver(handler)
observer.observe(sentinelEl)
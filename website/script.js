const isDarkMode = window.matchMedia && window.matchMedia('(prefers-color-scheme: dark)').matches;

if (isDarkMode)
{
    let link = document.querySelector("link[rel*='icon']");
    link.href = "resources/icons/music-icon-white.ico";
}
else
{
    let link = document.querySelector("link[rel*='icon']");
    link.href = "resources/icons/music-icon-black.ico";
}
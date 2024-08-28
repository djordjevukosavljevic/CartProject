document.getElementById("tryHereBtn").onclick() = function() {
    windows.alert("HI there!");
}

document.getElementById("submitBtn").addEventListener("mouseover", function(){
    this.textContent = "Changes!"
});

document.getElementById("submitBtn").addEventListener("mouseout", function(){
    this.textContent = "Here!"
});
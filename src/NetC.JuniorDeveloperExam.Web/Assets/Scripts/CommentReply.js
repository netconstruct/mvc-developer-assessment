function displayReplyForm(i) {
    var replyForm = document.getElementById("ReplyForm" + i);
    if (replyForm.style.display === "none") {
        replyForm.style.display = "block";
    } else {
        replyForm.style.display = "none";
    }
}
function validate() {
    
    var name = document.forms["help"]["funame"];
    var email = document.forms["help"]["email"];
    var issue = document.forms["help"]["issue"];
    
    if (name.value == "") {
        window.alert("Please enter your full name.");
        name.focus();
        return false
    }
    
    if (email.value == "") {
        window.alert("Please enter a valid email.");
        email.focus
        return false
        
    }
    
    if (email.value.indexOf("@", 0) < 0) {
        window.alert("Please enter a valid email.");
        email.focus
        return false
        
    }
    
    if (email.value.indexOf(".", 0) < 0) {
        window.alert("Please enter a valid email.");
        email.focus
        return false
        
    }
    
    if (issue.value == "") {
        window.alert("Please enter a brief description of your issue.");
        issue.focus
        return false
        
    }
    return true
}
var authority = "https://localhost:44343";
var xenaClientId = "mvc";
var xenaAPIEndpoint = "http://localhost:49000/Api/User/XenaUserMembership?forceNoPaging=0";

function log() {
    document.getElementById('results').innerText = '';

    Array.prototype.forEach.call(arguments, function (msg) {
        if (msg instanceof Error) {
            msg = "Error: " + msg.message;
        }
        else if (typeof msg !== 'string') {
            msg = JSON.stringify(msg, null, 2);
        }
        document.getElementById('results').innerHTML += msg + '\r\n';
    });
}

document.getElementById("login").addEventListener("click", login, false);
document.getElementById("api").addEventListener("click", api, false);
document.getElementById("logout").addEventListener("click", logout, false);

var config = {
    authority: authority,
    client_id: xenaClientId,
    redirect_uri: "http://localhost:5003/callback.html",
    response_type: "id_token token",
    scope:"openid profile testapi",
    post_logout_redirect_uri : "http://localhost:5003/index.html"
};
var mgr = new Oidc.UserManager(config);

mgr.getUser().then(function (user) {
    if (user) {
        log("User logged in", user.profile);
    }
    else {
        log("User not logged in");
    }
});
// https://mderriey.com/2016/08/21/openid-connect-and-js-applications-with-oidc-client-js/
function login() {
    mgr.signinPopup(); //signinRedirect();
}

function api() {
    mgr.getUser().then(function (user) {
        var url = xenaAPIEndpoint;

        var xhr = new XMLHttpRequest();
        xhr.open("GET", url);
        xhr.onload = function() {
            log(xhr.status, JSON.parse(xhr.responseText));
        };
        xhr.setRequestHeader("Authorization", "Bearer " + user.access_token);
        xhr.send();
    });
}

function logout() {
    mgr.signoutRedirect();
}
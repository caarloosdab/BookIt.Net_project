
window.bookItTimeZone = {
    get: function () {
        return Intl.DateTimeFormat().resolvedOptions().timeZone;
    }
};

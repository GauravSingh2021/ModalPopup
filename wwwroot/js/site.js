(function ($) {
    function Index() {
        var $this = this;
        function initialize() {

            $(".popup").on('click', function (e) {
                modelPopup(this);
            });

            function modelPopup(reff) {
                var url = $(reff).data('url');

                $.get(url).done(function (data) {
                    debugger;
                    $('#modal-create-edit-user').find(".modal-dialog").html(data);
                    $('#modal-create-edit-user > .modal', data).modal("show");
                });

            }
        }

        $this.init = function () {
            initialize();
        };
    }
    $(function () {
        var self = new Index();
        self.init();
    });
}(jQuery));

(function ($) {
    function Index() {
        var $this = this;
        function initialize() {

            $(".popup").on('click', function (e) {
                modelPopup(this);
            });

            function modelPopup(reff) {
                var url = $(reff).data('url');

                $.get(url).done(function (data) {
                    debugger;
                    $('#modal-edit-user').find(".modal-dialog").html(data);
                    $('#modal-edit-user > .modal', data).modal("show");
                });

            }
        }

        $this.init = function () {
            initialize();
        };
    }
    $(function () {
        var self = new Index();
        self.init();
    });
}(jQuery));

(function ($) {
    function Index() {
        var $this = this;
        function initialize() {

            $(".popup").on('click', function (e) {
                modelPopup(this);
            });

            function modelPopup(reff) {
                var url = $(reff).data('url');

                $.get(url).done(function (data) {
                    debugger;
                    $('#modal-details-user').find(".modal-dialog").html(data);
                    $('#modal-details-user > .modal', data).modal("show");
                });

            }
        }

        $this.init = function () {
            initialize();
        };
    }
    $(function () {
        var self = new Index();
        self.init();
    });
}(jQuery));




    
    

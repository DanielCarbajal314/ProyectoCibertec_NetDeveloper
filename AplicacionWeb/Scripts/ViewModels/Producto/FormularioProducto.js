function FormularioProducto() {
    var self = this;
    self.Nombre = ko.observable("");
    self.Precio = ko.observable("");
    self.Productos = ko.observableArray([]);

    self.LimpiarFormulario = function () {
        self.Nombre("");
        self.Precio("");
    }

    self.TraerDatosDelServidor = function () {
        $.get("api/productos", function (productos) {
            productos.forEach(function (producto) {
                self.Productos.push(producto);
            });
        });
    }

    self.RegistrarProducto = function () {
        var dataDelProducto = self.SacarDataDelFormulario();
        Post(
                "../api/productos",
                dataDelProducto,
                function (producto) {
                    AgregarProductoATabla(producto);
                    tablaDeProductos.draw();
                    self.LimpiarFormulario();
                    $.notify(producto.Nombre + " se creo con exito", "success");
                }
        );
    }

    self.SacarDataDelFormulario = function () {
        return {
            Nombre : self.Nombre(),
            Precio: self.Precio(),
            IdsDeLasCategorias : []
        }
    }


    return self;
}
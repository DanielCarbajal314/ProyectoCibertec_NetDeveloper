function FormularioProducto() {
    var self = this;
    self.Nombre = ko.observable("");
    self.Precio = ko.observable("");

    self.LimpiarFormulario = function () {
        self.Nombre("");
        self.Precio("");
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
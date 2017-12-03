function FormularioProducto() {
    var self = this;
    self.Nombre = ko.observable("");
    self.Precio = ko.observable("");
    self.Productos = ko.observableArray([]);
    self.TablaDeProductos = $('#TablaDeProductos').DataTable();


    self.LimpiarFormulario = function () {
        self.Nombre("");
        self.Precio("");
    }

    self.TraerDatosDelServidor = function () {
        $.get("api/productos", function (productos) {
            self.Productos(productos)
            self.Productos.valueHasMutated();
        });
    }

    self.AgregarProductoATabla = function (producto) {
        self.TablaDeProductos.row.add(
                    [
                        producto.Id,
                        producto.Nombre,
                        producto.Precio
                    ]
        );
    }

    self.Productos.subscribe(function () {
        self.TablaDeProductos.clear();
        self.Productos().forEach(function (producto) {
            self.AgregarProductoATabla(producto);
        })
        self.TablaDeProductos.draw()
    })

    self.RegistrarProducto = function () {
        var dataDelProducto = self.SacarDataDelFormulario();
        Post(
                "../api/productos",
                dataDelProducto,
                function (producto) {
                    self.Productos.push(producto);
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
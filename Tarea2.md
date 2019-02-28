# Declaración de clases: atributos, métodos, encapsulamiento.

Las clases y las estructuras encapsulan un conjunto de datos y comportamientos que forman un conjunto como una unidad; los datos y comportamientos son miembros de la clase o estructura, en estos se incluyen sus metodos, propiedades y eventos entre otras cosas. Una clase es un tipo de referencia que; cuando se crea un objeto de la clase, la variable a la que se asigna el objeto contiene una referencia a esa memoria. Cuando la referencia de objeto se asigna a una nueva variable, la nueva hace referencia al objeto original.

# Instanciación de una clase.

El operador __new__ se usa para crear objetos e invocar constructores, tambien se usa para crear instantias de tipos anónimos. El operador new tambien sirve para invocar el constructor predeterminado para tipos de valor.

# Métodos: declaración, mensajes, paso de parámetros, retorno de valores.

Los parametros de un metodo pueden ser declarados como in, ref o out; estas sirven para que el manejo de las parametros sea mas preciso en lo que es la lectura de datos por metodos y la escritura de datos de los metodos.

## params

Es como una lista unidimensional el cual puede especificar un parametro de metodos que toma un numero variable de argumentos; puede enviar una lista separada por comas de argumentos del tipo especificado en la declaracion de parametro o una matriz de argumentos del tipo especificado.

# ref

__ref__ indica un valor que se ha pasado mediante referencia se puede usar en cuatro casos:

1. En una firma del metodo y en una llamada al metodo.

2. En una firma del metodo, para devolver un valor al autor de la llamada mediante referencia.

3. En un cuerpo de miembro, para indicar que un valor devuelto de referencia se alacena localmente como una referencia que el autor de la llamada pretende modificar o, en general, que una variable local accede a otro valor por referencia.

4. En una declaracion __struct__ para declarar __ref__ __struct__ o __ref__ __Readonly__ __struct__.

# out

La palabra clave out se puede usar en dos casos:

1. Como modificador de parametro, el cual le permite pasar un argumento a un metodo mediante una referencia en lugar de mediante un valor.

2. En declaraciones de parametros de tipo generico para interfaces y delgados, que especifica que un parametro de tipo es covariante.

## Constructores y destructores: declaración, uso y aplicaciones.

Los constructores son metodos de clase que se ejecutan cuando se crea un objeto de un tipo determinado; estos tienen el mismo nombre que la clase y normalmente inicializan los miembros de datos del nuevo objeto.
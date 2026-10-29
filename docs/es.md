# Constructor de escenas — escenas Godot de un mod con vista previa en vivo

El constructor de escenas edita las escenas Godot de un mod (`.tscn`: paneles, piezas del HUD, rótulos) encima de una pantalla del juego en marcha. Ves la escena donde aparecerá, arrastras sus nodos, cambias sus propiedades en un inspector y el archivo se reescribe sin perder las partes que el constructor no muestra.

## Cómo abrirlo

Botón del martillo en la barra del juego → **Constructor de escenas**.

## Editar una escena

1. La primera lista es la escena base sobre la que se muestra la escena del mod (o una vacía).
2. **Mod** y **Escena del mod (.tscn)**: el archivo que se edita.
3. Elige un nodo pulsándolo en la vista previa o en **Jerarquía**. El dorado es la raíz de la escena del mod, los nodos brillantes se pueden editar y los tenues pertenecen a la escena base y son de solo lectura.
4. Arrastra un nodo por su cuerpo o por sus asas, o cambia sus propiedades en **Inspector** (números, texto, colores, interruptores, posiciones). Los cambios del inspector y de las asas se guardan solos.
5. Añade un nodo del tipo elegido dentro del nodo seleccionado, o borra el nodo seleccionado con sus hijos (Supr).
6. La pestaña **Código .tscn** muestra el texto; los cambios a mano se guardan con Ctrl+S, que además reconstruye la vista previa. **Recargar desde el disco** descarta los cambios sin guardar.

En el archivo solo se reescriben los valores cambiados; los recursos, las conexiones y las propiedades que el inspector no conoce quedan como estaban.

## Límites

- Solo mods de carpeta; un mod empaquetado no se puede guardar («el mod es de solo lectura»).
- Los nodos de la escena base se muestran como referencia y nunca se escriben.

## Dependencias

`tools_base`, `ui_base`.
El paquete antiguo `editor_tools` instala este mod junto con las demás ventanas de autor.

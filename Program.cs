﻿
FabricaDePersonaje fabricaDePersonaje = new FabricaDePersonaje();

Personaje miPersonaje = FabricaDePersonaje.CrearPersonaje();

string jsonString = JsonSerializer.Serialize(miPersonaje);
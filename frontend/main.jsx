import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App";

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);

// ⚠️ Se quiser testar sem backend, instale json-server e rode:
// npm install -g json-server
// json-server --watch db.json --port 3001

// Exemplo de db.json:
// {
//   "usuarios": [],
//   "animais": []
// }
* {
  box-sizing: border-box;
}

body {
  margin: 0;
  font-family: 'Inter', sans-serif;
  background-color: #f9f9f9;
  color: #333;
}

header {
  background-color: #1a237e;
  color: white;
  padding: 1.5rem 1rem;
  text-align: center;
  position: relative;
}

.logo {
  position: absolute;
  top: 1rem;
  left: 1rem;
  height: 50px;
}

header h1 {
  margin: 0;
  font-size: 2rem;
}

header p {
  margin-top: 0.5rem;
  font-size: 1.1rem;
}

main {
  max-width: 900px;
  margin: auto;
  padding: 2rem 1rem;
}

section {
  margin-bottom: 2rem;
}

h2 {
  color: #1a237e;
  margin-bottom: 0.5rem;
}

.service {
  background: white;
  border-radius: 8px;
  padding: 1.5rem;
  box-shadow: 0 2px 6px rgba(0,0,0,0.1);
  margin-bottom: 1.5rem;
}

.image-placeholder {
  background-color: #ddd;
  width: 100%;
  height: 200px;
  border-radius: 6px;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #666;
  font-size: 0.9rem;
  margin-top: 1rem;
}

footer {
  text-align: center;
  padding: 1rem;
  background-color: #eee;
  font-size: 0.9rem;
}

@media (max-width: 600px) {
  . {
    height: 40px;
    top: 0.8rem;
    left: 0.8rem;
  }
}

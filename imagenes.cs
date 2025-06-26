* {
  box-sizing: border-box;
}

body {
  margin: 0;
  font-family: 'Inter', sans-serif;
  background-color: #f5f7fa;
  color: #333;
}

header {
  background-color: #1a237e;
  color: white;
  padding: 2rem 1rem;
  display: flex;
  align-items: center;
  justify-content: center;
  flex-wrap: wrap;
  position: relative;
  text-align: center;
}

.log {
  max-height: 80px;
  margin-right: 1rem;
}

.header-text h1 {
  margin: 0;
  font-size: 2.2rem;
}

.header-text p {
  margin-top: 0.3rem;
  font-style: italic;
  font-size: 1rem;
}

main {
  max-width: 1000px;
  margin: auto;
  padding: 2rem 1rem;
}

.service {
  background: white;
  border-left: 5px solid #f57c00;
  border-radius: 8px;
  padding: 1.5rem;
  margin-bottom: 2rem;
  box-shadow: 0 4px 12px rgba(0,0,0,0.07);
  transition: transform 0.3s, box-shadow 0.3s;
}

.service:hover {
  transform: translateY(-4px);
  box-shadow: 0 6px 16px rgba(0,0,0,0.1);
}

.service h2 {
  margin-top: 0;
  color: #1a237e;
}

.image-placeholder {
  background-color: #e0e0e0;
  width: 100%;
  height: 200px;
  border-radius: 6px;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #555;
  font-size: 0.95rem;
  margin-top: 1rem;
  font-style: italic;
}

footer {
  background-color: #1a237e;
  color: white;
  text-align: center;
  padding: 1rem;
  font-size: 0.9rem;
}

@media (max-width: 600px) {
  .logo {
    margin: 0 auto 1rem;
  }

  header {
    flex-direction: column;
  }
}

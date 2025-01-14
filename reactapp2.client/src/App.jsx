import './App.css';

function App() {
    return (
        <div className="app-container">
            <header className="hero-section">
                <nav className="navbar">
                    <div className="logo">موقعي الشخصي</div>
                    <ul className="nav-links">
                        <li><a href="#about">نبذه عني</a></li>
                        <li><a href="#projects">المشاريع</a></li>
                        <li><a href="#contact">تواصل معي</a></li>
                    </ul>
                </nav>
                <div className="hero-content">
                    <p>مرحباً، أنا محمد ناصر </p>
                        <p>مطور مبدع يقدم تجارب رقمية مميزة.</p>
                        <a href="#projects" className="cta-button">شاهد أعمالي</a>
                </div>
            </header>

            <main>
                <section id="about" className="about-section">
                    <h2>نبذة عني </h2>
                    <p>محمد.</p>
                </section>

                <section id="projects" className="projects-section">
                    <h2>المشاريع</h2>
                    <div className="project-list">
                        <div className="project-card">
                            <h3>عنوان المشروع </h3>
                            <p>وصف مختصر للمشروع. تم بناؤه باستخدام React, Node.js، والمزيد.</p>
                            <a href="https://github.com/username/project" target="_blank" rel="noopener noreferrer">عرض الكود</a>
                        </div>
                        <div className="project-card">
                            <h3>عنوان المشروع </h3>
                            <p>وصف مختصر للمشروع. تم بناؤه باستخدام React, Node.js، والمزيد.</p>
                            <a href="https://github.com/username/project" target="_blank" rel="noopener noreferrer">عرض الكود</a>
                        </div>
                    </div>
                </section>

                <section id="contact" className="contact-section">
                    <h2>تواصل معي</h2>
                    <p>أنا متاح للتعاون وفرص جديدة. لا تتردد في التواصل!</p>
                    <a href="mailto:your.email@example.com" className="cta-button">أرسل لي بريداً</a>
                </section>
            </main>

            <footer className="footer">
                <p>&copy; 2025 [محمد]. جميع الحقوق محفوظة.</p>
                <div className="social-links">
                    <a href="https://github.com/username" target="_blank" rel="noopener noreferrer">GitHub</a>
                    <a href="https://linkedin.com/in/username" target="_blank" rel="noopener noreferrer">LinkedIn</a>
                </div>
            </footer>
        </div>
    );
}

export default App;

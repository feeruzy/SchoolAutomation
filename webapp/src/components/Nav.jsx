import { Nav, Navbar } from "react-bootstrap";

function NavComponent() {
    return (
        <>
            <Navbar>
                <Navbar.Brand href="#home">مدرسه من</Navbar.Brand>
                <Nav className="me-auto">
                    <Nav.Link>درباره</Nav.Link>
                    <Nav.Link href="login">نام کاربر</Nav.Link>
                </Nav>
            </Navbar>
        </>
    )
}

export default NavComponent;
import { Accordion } from "react-bootstrap";

function MainWindow({title}) {
    return (
        <Accordion defaultActiveKey="0">
            <Accordion.Item eventKey='0'>
                <Accordion.Header>{title}</Accordion.Header>
                <Accordion.Body>
                    
                </Accordion.Body>
            </Accordion.Item>
        </Accordion>
    )
}

export default MainWindow;
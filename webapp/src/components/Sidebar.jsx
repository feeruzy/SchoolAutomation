import { Accordion, ListGroup } from "react-bootstrap";

function Sidebar() {
    return (
        <Accordion defaultActiveKey="0">
            <Accordion.Item eventKey="0">
                <Accordion.Header>اطلاعات پایه</Accordion.Header>
                <Accordion.Body>
                    <ListGroup>
                        <ListGroup.Item action href="student">دانش آموزان</ListGroup.Item>
                        <ListGroup.Item action>پایه‌های تحصیلی</ListGroup.Item>
                        <ListGroup.Item action>کلاس‌ها</ListGroup.Item>
                        <ListGroup.Item action>رشته‌های تحصیلی</ListGroup.Item>
                        <ListGroup.Item action>دروس</ListGroup.Item>
                        <ListGroup.Item action>موارد انضباطی</ListGroup.Item>
                    </ListGroup>
                </Accordion.Body>
            </Accordion.Item>
            <Accordion.Item eventKey="1">
                <Accordion.Header>کارتابل‌</Accordion.Header>
                <Accordion.Body>
                    <ListGroup>
                        <ListGroup.Item action>ثبت نمره</ListGroup.Item>
                        <ListGroup.Item action>ثبت مورد انضباطی</ListGroup.Item>
                        <ListGroup.Item action>ارسال پیام و دعوتنامه</ListGroup.Item>
                    </ListGroup>
                </Accordion.Body>
            </Accordion.Item>
            <Accordion.Item eventKey="2">
                <Accordion.Header>گزارش‌ها</Accordion.Header>
                <Accordion.Body>
                    <ListGroup>
                        <ListGroup.Item action>گزارش نمرات یک دانش آموز</ListGroup.Item>
                        <ListGroup.Item action>نمرات یک درس</ListGroup.Item>
                        <ListGroup.Item action>نمرات یک کلاس</ListGroup.Item>
                        <ListGroup.Item action>موارد انضباطی یک دانش آموز</ListGroup.Item>
                        <ListGroup.Item action>موارد انضباطی یک کلاس</ListGroup.Item>
                        <ListGroup.Item action>گزارش جامع یک دانش آموز</ListGroup.Item>
                    </ListGroup>
                </Accordion.Body>
            </Accordion.Item>
        </Accordion>
    )
}

export default Sidebar;
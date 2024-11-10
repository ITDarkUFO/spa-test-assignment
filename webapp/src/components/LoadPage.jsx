import { Skeleton, Col, Row, Flex, Card } from 'antd';

const LoadPage = ({ pageSize }) => {
    var cardsCount = pageSize;
    var cards = [];

    for (var i = 0; i < cardsCount; i++) {
        cards.push(
            <Row key={i}>
                <Card hoverable loading className="card"></Card>
            </Row>
        );
    }

    return (
        <>
            <Flex justify="space-between" style={{ marginBottom: "25px" }}>
                <Skeleton.Input active size="large" />
                <Skeleton.Input active size="large" />
            </Flex>
            <Col className="cards-grid">
                {cards}
            </Col>
            <Skeleton.Input active block size="large" />
        </>
    );
};

export default LoadPage;